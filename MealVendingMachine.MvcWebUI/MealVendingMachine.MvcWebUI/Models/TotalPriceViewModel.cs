using MealVendingMachine.MvcWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Models
{
    public class TotalPriceViewModel
    {
        double sum = 0;
        public List<Foods> FoodsPrice { get; set; }
        public List<Payments> Payments { get; set; }



        //public double foodstotalprice()
        //{
        //    return (double)FoodsPrice.Sum(i => i.foodprice * i.foodQuantity);
        //}
    }
}
