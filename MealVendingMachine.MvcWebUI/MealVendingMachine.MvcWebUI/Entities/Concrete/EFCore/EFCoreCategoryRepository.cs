using MealVendingMachine.MvcWebUI.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities.Concrete.EFCore
{
    public class EFCoreCategoryRepository : EFCoreRepository<Categories, MealContext>, ICategoryRepository
    {
    }
}
