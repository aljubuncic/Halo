namespace Halo.Models
{
    public class Journalist : User
    {
        public List<Article> Articles { get; set; } 
        public Journalist() { }
    }
}
