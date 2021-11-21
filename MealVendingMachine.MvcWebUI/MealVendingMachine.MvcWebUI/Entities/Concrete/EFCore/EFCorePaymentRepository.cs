using MealVendingMachine.MvcWebUI.Entities.Abstract;
using MealVendingMachine.MvcWebUI.Entities.Concrete.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities.Concrete
{
    public class EFCorePaymentRepository : EFCoreRepository<Payments, MealContext>, IPaymentRepository
    {
    }
}
