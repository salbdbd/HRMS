namespace HRMS.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public int CompId { get; set; }
        public int BranchId { get; set; }
        public int EmpId { get; set; }
        public int Status { get; set; }
     
    }
}
