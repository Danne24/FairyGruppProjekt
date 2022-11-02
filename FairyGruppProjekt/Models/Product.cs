using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FairyGruppProjekt.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }

        public string? ImageThumbnailUrl { get; set; }

        public bool IsOnSale { get; set; }
        public int AmountOfCopiesInStorage { get; set; }
        public int? AmountOfCopiesSold { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
