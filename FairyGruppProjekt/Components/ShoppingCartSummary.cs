using FairyGruppProjekt.Models;
using FairyGruppProjekt.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FairyGruppProjekt.Components
{
    public class ShoppingCartSummary : ViewComponent
    {

        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }


        public IViewComponentResult Invoke()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();


            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}
