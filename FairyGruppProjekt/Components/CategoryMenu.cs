using FairyGruppProjekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace FairyGruppProjekt.Components
{
 
        public class CategoryMenu : ViewComponent
        {
            private readonly ICategoryRepository _categoryRepository;

            public CategoryMenu(ICategoryRepository categoryRepository)
            {
                _categoryRepository = categoryRepository;
            }

            public IViewComponentResult Invoke()
            {
                var categories = _categoryRepository.GetAllCategory.OrderBy(c => c.CategoryName);

                return View(categories);
            }
        }
    
}
