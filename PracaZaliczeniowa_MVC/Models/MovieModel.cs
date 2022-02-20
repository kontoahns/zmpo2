namespace PracaZaliczeniowa_MVC.Models
{
    // Model przechowujący właściwości filmu który ma zostać odtworzony
    public class MovieModel
    {
        public int id { get; set; } //ID filmu
        public string name { get; set; } //Nazwa filmu
        public int rating { get; set; } //Ocena filmu
        public string ?start { get; set; } //Godzina rozpoczęcja filmu
        public string ?end { get; set; } //Godzina zakończenia filmu
        public int room { get; set; } //Sala w której będzie można zobaczyć film
        public int? cancelled { get; set; } // Czy seans został odwołany
    }
}
