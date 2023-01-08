using System.ComponentModel.DataAnnotations;

namespace NodesApp.Models.AccountModels
{
    public class EditAccountModel
    {
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password incorrect")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

        public string TelegramId { get; set; }
    }
}
