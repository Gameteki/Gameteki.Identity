namespace Gameteki.Identity.UI.Account
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterInputModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}