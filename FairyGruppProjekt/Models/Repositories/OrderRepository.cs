using FairyGruppProjekt.Data;
using FairyGruppProjekt.Models.Interfaces;
using System;

namespace FairyGruppProjekt.Models.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();


            foreach (var shoppigCartItem in shoppingCartItems)
            {
                var orderDetails = new OrderDetail
                {
                    Amount = shoppigCartItem.Amount,
                    Price = shoppigCartItem.Product.Price,
                    ProductId = shoppigCartItem.Product.ProductId,
                    OrderId = order.OrderId
                };

                _appDbContext.OrderDetails.Add(orderDetails);
            }
            _appDbContext.SaveChanges();
        }
    }
}
