using System.ComponentModel.DataAnnotations;

namespace FairyGruppProjekt.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemsId { get; set; }
        public string ShoppingCartId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
