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
    public class MachineNumbersViewComponent : ViewComponent
    {
        private IFoodRepository _foodsRepository;
        private IBeverageRepository _beverageRepository;
        public MachineNumbersViewComponent(IFoodRepository foodsRepository,IBeverageRepository beverageRepository)
        {
            _beverageRepository = beverageRepository;
            _foodsRepository = foodsRepository;
        }
        
        public IViewComponentResult Invoke()
        {
            
            var model = new MachineNumbersViewModel()
            { 
                
                GetFoods=_foodsRepository.GetAll(),
                GetBeverages=_beverageRepository.GetAll()
            };
            return View(model);
        }
        
    }
}
