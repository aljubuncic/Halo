namespace Halo.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string AdvertiserEmail { get; set; }
        public string Image { get; set; } //treba skontat kako evidentirat tipove oglasavanja, ovdje sam samo stavio sliku ako se radi o banneru
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDays { get; set; }
        public double Price { get; set; }   
        public Advertisement() { }
    }
}
