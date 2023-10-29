using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must have 5-15 characters")]
        public string? UserName { get; set;}

        [EmailAddress]
        public string? Email { get; set;}

        [Required(ErrorMessage = "Password Required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Password must by 6-20 characters")]
        [Compare("VerifyPassword", ErrorMessage = "The passwords must match")]
        public string? Password { get; set;}

        [Required(ErrorMessage = "Password Required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must by 6-20 characters")]
        public string? VerifyPassword { get; set;}

    }
}
