using DAHP.Domain;
using DAHP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Application
{
    class PayrollManagementServices
    {
        HPDbContext context;

        public PayrollManagementServices()
        {
            context = new HPDbContext();
        }
        public Guid createEmployeeTypeId(PaymentSchedule PaymentSchedule)
        {
            context.PaymentSchedules.Add(PaymentSchedule);
        }
    }
        
}
