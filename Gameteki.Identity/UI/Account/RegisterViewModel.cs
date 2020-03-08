namespace Gameteki.Identity.UI.Account
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "Username")]
        [RegularExpression("^[A-Za-z0-9_-]+$", ErrorMessage = "Usernames must only use the characters a-z, 0-9, _ and -")]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string ReturnUrl { get; set; }
        public IList<ExternalProvider> ExternalProviders { get; set; }
    }
}