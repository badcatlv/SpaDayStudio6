namespace SpaDay6.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; }

        public User() {
            Date = DateTime.Now;
        }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            
            ;
        }
    }
}
