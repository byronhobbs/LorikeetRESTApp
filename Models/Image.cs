using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LorikeetRESTApp.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public IFormFile MemberFile { get; set; }
    }
}
