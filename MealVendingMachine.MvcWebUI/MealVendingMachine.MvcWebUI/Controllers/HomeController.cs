using MealVendingMachine.MvcWebUI.Entities;
using MealVendingMachine.MvcWebUI.Entities.Abstract;
using MealVendingMachine.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IFoodRepository _foodRepository;
        private IBeverageRepository _beverageRepository;
        private IPaymentRepository _paymentRepository;

        public HomeController(IFoodRepository foodRepository, IBeverageRepository beverageRepository, IPaymentRepository paymentRepository)
        {
            _foodRepository = foodRepository;
            _beverageRepository=beverageRepository;
            _paymentRepository = paymentRepository;
        }
        public IActionResult Index(int? id)
        {
            var foods = _foodRepository.GetAll();
            var beverages = _beverageRepository.GetAll();

            if (id!=null)
            {
                if (id==1)
                {
                    ViewBag.control = "true";
                }
                else if(id==2)
                {
                    ViewBag.control = "false";
                }
                else
                {
                    ViewBag.control = "";
                }
                foods = foods.Where(f => f.categoryId == id).ToList();
                beverages = beverages.Where(b => b.categoryId == id).ToList();
            }
            var model = new MealListViewModel
            {
                GetFoods = foods,
                GetBeverages=beverages
                
            };
            return View(model);
        }
        public IActionResult FoodDetail(int id)
        {
            var foods = _foodRepository.GetById(id);
            

            var model = new DetailViewModel
            {
                GetFoods = foods
               

            };
            return View(model);
        }
        public IActionResult BeverageDetail(int id)
        {
            
            var beverages = _beverageRepository.GetById(id);

            var model = new DetailViewModel
            {
                
                GetBeverages = beverages

            };
            return View(model);
        }

        
    }
}
