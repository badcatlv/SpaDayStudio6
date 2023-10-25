using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModel
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string UserName { get; set;}
        [EmailAddress]
        public string Email { get; set;}
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set;}
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string VerifyPassword { get; set;}

    }
}
