namespace API.Models
{
    public class HotelInfo
    {
        // public IConfiguration Configuration {get;}
        public const string Info = "Info";
        public string Tittle{ get; set; }
        public string Tagline{ get; set; }
        public string Email{ get; set; }
        public string Website{ get; set; }
        public Address Location{ get; set; }
        public string Href {get;set;}
        
    }

    public class Address{
        public string Street{ get; set; }
        public string City{ get; set; }
        public string Country{ get; set; }
    }
}