using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities.Abstract
{
    public interface IFoodRepository:IRepository<Foods>
    {
        List<Foods> GetFoodCampaigns();
    }
}
