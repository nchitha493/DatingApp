using System.Security.Claims;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public ClaimsIdentity UserName { get; internal set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
       
        
    }
}