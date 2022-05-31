namespace NET_CORE.Models
{
    public class Lecture
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime RelaseDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public decimal Pages { get; set; }
    }
}
