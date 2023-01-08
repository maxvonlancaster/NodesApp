using System.ComponentModel.DataAnnotations;

namespace NodesApp.Models.AccountModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username not specified")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
