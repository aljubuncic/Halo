namespace Halo.Models
{
    public class ArticleMistake
    {
        public int Id { get; set; }
        public Article Article { get; set; }
        public string MistakeExplanation { get; set; }
    }
}
