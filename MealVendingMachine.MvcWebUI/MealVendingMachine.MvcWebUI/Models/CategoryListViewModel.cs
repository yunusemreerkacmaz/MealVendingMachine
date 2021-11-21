using MealVendingMachine.MvcWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Categories> GetCategories { get; set; }
    }
}
