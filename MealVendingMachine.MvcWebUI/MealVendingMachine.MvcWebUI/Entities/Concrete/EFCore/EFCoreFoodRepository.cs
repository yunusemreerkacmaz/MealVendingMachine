using MealVendingMachine.MvcWebUI.Entities.Abstract;
using MealVendingMachine.MvcWebUI.Entities.Concrete.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities.Concrete
{
    public class EFCoreFoodRepository : EFCoreRepository<Foods, MealContext>, IFoodRepository
    {
        public List<Foods> GetFoodCampaigns()
        {
            using (var context = new MealContext())
            {
                return context.Foods.ToList();
            }
        }
    }
}
