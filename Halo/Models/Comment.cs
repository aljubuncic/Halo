using Microsoft.AspNetCore.Identity;

namespace Halo.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        /*public int Upvotes { get; set; }
        public int Downvotes { get; set; }  */
        public IdentityUser RegisteredUser { get; set; }
        public List<Report> Reports { get; set; }   

        public Comment()
        {
            
        }
    }
}
