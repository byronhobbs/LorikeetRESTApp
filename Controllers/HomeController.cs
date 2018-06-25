using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Authorization;

namespace LorikeetRESTApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFileProvider fileProvider;

        private const string memberPicDirectory = "memberpics";

        public HomeController(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/files/upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var directory = Path.Combine(Directory.GetCurrentDirectory(), memberPicDirectory, file.FileName);

            if (!Directory.Exists(Path.GetDirectoryName(directory)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(directory));
            }

            using (var stream = new FileStream(directory, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(file.FileName + " uploaded successfully");
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/files/uploads")]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
                return Content("files not selected");

            var directory = Path.Combine(Directory.GetCurrentDirectory(), memberPicDirectory);

            if (!Directory.Exists(Path.GetDirectoryName(directory)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(directory));
            }

            foreach (var file in files)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), memberPicDirectory, file.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return Ok(files.Count + " files uploaded Successfully");
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/files/download/{filename}")]
        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename not present");

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), memberPicDirectory, filename);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File Not Found");
            }

            var memory = new MemoryStream();
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(filePath), Path.GetFileName(filePath));
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
    }
}