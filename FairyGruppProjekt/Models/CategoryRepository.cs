using FairyGruppProjekt.Data;
using System.Collections.Generic;
using System;

namespace FairyGruppProjekt.Models
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CategoryRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategory => _appDbContext.Categories;

       
    }
}
