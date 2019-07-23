using HRMS.Models;

namespace HRMS.ViewModels
{
    public class UserViewModel : UserModel
    {
        public string RoleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName.Trim() + " " + LastName.Trim();
        public string NickName { get; set; }
    }
}