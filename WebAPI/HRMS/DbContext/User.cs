using System.Linq;
using Dapper.Framework;
using HRMS.ViewModels;

namespace HRMS.DbContext
{
    public class User
    {
        public static UserViewModel Login(string email, string password)
        {
            var parameters = new {Email = email, Password = password};
            var users = Connection.ExecuteReader<UserViewModel>("usp_User_Login", parameters).ToList();
            return users.FirstOrDefault();
        }
    }
}