using System.ComponentModel.DataAnnotations;

namespace FairyGruppProjekt.Models
{
    public class Customer 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }

    }
}
