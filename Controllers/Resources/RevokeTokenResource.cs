using System.ComponentModel.DataAnnotations;

namespace LorikeetRESTApp.Controllers.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}