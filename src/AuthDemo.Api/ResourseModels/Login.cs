using System.ComponentModel.DataAnnotations;

namespace AuthDemo.Api.ResourseModels
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
