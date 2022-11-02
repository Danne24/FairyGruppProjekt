using FairyGruppProjekt.Models;

namespace FairyGruppProjekt.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }

        public IEnumerable<Product> QueryMostSoldProducts { get; set; }



    }
}
