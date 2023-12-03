using Microsoft.AspNetCore.Identity;

namespace Halo.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ArticleCategory Category { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Journalist Journalist { get; set; }
        public string Content { get; set; }
        public List<string> Images { get; set; }
        //mozda? public List<string> Tags { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ArticleMistake> ReportedMistakes { get; set; }
        public Article()
        {
            
        }

    }
}
