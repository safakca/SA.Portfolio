namespace SA.Portfolio.Models
{
    public class Admin : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}