using Microsoft.AspNetCore.Identity;

namespace Halo.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Comment Comment { get; set; }
        public RegisteredUser RegisteredUser { get; set; }
        public string Reason { get; set; }
        public Report()
        {
            
        }
    }
}
