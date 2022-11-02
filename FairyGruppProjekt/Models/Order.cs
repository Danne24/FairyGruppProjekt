using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FairyGruppProjekt.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your first Name!")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Last Name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter your City Name")]
        [Display(Name = "City")]
        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter your Zip Code")]
        [Display(Name = "Zip Code")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please Enter your Phone Number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }
        public DateTime? ExactDateOrderplaced { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
