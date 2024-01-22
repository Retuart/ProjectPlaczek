using System.ComponentModel.DataAnnotations;
namespace project.core.Models.DTO
{
    public class User
    {
        public string? Id { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Role Name")]
        public IList<string> RoleName { get; set; }
    }
}
