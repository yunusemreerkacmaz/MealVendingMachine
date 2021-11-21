using MealVendingMachine.MvcWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Models
{
    public class DetailViewModel
    {
        public Foods GetFoods { get; set; }
        public Beverages GetBeverages { get; set; }
    }
}
