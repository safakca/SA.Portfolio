namespace SA.Portfolio.Models
{
    public class Testimonial : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Profession { get; set; }
        public int? Balance { get; set; }
    }
}