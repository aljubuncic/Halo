namespace Halo.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<string> Images { get; set; }
        //ovdje sam mislio da ne ubacujem objekat usera
        //jer ipak trebaju formalnije informacije kojih nema u tom objektu
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public News()
        {
            
        }
    }
}
