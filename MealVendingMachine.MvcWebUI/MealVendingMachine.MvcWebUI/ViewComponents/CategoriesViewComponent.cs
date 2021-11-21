using MealVendingMachine.MvcWebUI.Entities;
using MealVendingMachine.MvcWebUI.Entities.Abstract;
using MealVendingMachine.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryRepository _categoryRepository;
        public CategoriesViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            
            var categories = new CategoryListViewModel()
            {
                GetCategories=_categoryRepository.GetAll()

            };
            
            return View(categories);
        }
    }
}
