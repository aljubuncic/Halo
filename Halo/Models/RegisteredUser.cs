namespace Halo.Models
{
    public class RegisteredUser : User
    {
        public List<Comment> Comments { get; set; } 
        public List<Report> Reports { get; set; }
        public RegisteredUser() { }
    }
}
