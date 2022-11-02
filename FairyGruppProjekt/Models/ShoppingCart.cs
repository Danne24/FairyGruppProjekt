using FairyGruppProjekt.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace FairyGruppProjekt.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _appDbContext;

        public string ShoppingCartID { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartID") ?? Guid.NewGuid().ToString();
            session.SetString("CartID", cartId);

            return new ShoppingCart(context) { ShoppingCartID = cartId };
        }

        public void AddToCart(Product product, int amount)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(c => c.Product.ProductId == product.ProductId
            && c.ShoppingCartId == ShoppingCartID);

            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartID,
                    Product = product,
                    Amount = amount
                };
                _appDbContext.ShoppingCartItems.Add(ShoppingCartItem);
            }

            else
            {
                ShoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(c => c.Product.ProductId == product.ProductId
            && c.ShoppingCartId == ShoppingCartID);

            var localAmount = 0;

            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                    localAmount = ShoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(ShoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();
            return localAmount;
        }


        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.
                Where(c => c.ShoppingCartId == ShoppingCartID).
                Include(s => s.Product).ToList());
        }


        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartID);
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }


        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.
                Where(c => c.ShoppingCartId == ShoppingCartID).
                Select(c => c.Product.Price * c.Amount).
                Sum();

            return total;
        }

    }
}
