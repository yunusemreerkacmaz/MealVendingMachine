using MealVendingMachine.MvcWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Models
{
    public class MealListViewModel
    {
        public List<Foods> GetFoods { get; set; }
        public List<Beverages> GetBeverages { get; set; }
    }
}
