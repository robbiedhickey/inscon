namespace Enterprise.Services.Authentication.Models
{
    public class PasswordHistory
    {
        public string Password { get; set; }
        public string PasswordSalt { get; set; }

        public PasswordHistory(string password, string salt)
        {
            Password = password;
            PasswordSalt = salt;
        }
    }
}
