namespace LabOOP.Models
{
    public static class UserRoles
    {
        public const string User = "user";
        public const string Admin = "admin";
        public const string SuperAdmin = "superAdmin";
        public static string GetRole(string email)
        {
            if (email == "baryshAdmin@gmail.com")
                return Admin;
            else
                return User;
        }
    }
}
