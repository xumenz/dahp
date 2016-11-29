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
        public Guid createPaymentSchedule(PaymentSchedule PaymentSchedule)
        {
            context.PaymentSchedules.Add(PaymentSchedule);
            context.SaveChanges();

            return PaymentSchedule.PayrollCategoryId;
        }
        public IList<PaymentSchedule> GetPaymentSchedules()
        {
            return context.PaymentSchedules.ToList();
        }
        public PaymentSchedule GetPaymentSchedule(Guid id)
        {
            return context.PaymentSchedules.Find(id);
        }


        public Guid createEmployeeSalaryInfo(EmployeeSalaryInfo EmployeeSalaryInfo)
        {
            context.EmployeeSalaryInfos.Add(EmployeeSalaryInfo);
            context.SaveChanges();

            return EmployeeSalaryInfo.Id;
        }
        public IList<EmployeeSalaryInfo> GetEmployeeSalaryInfos()
        {
            return context.EmployeeSalaryInfos.ToList();
        }

        public EmployeeSalaryInfo GetEmployeeSalaryInfo(Guid id)
        {
            return context.EmployeeSalaryInfos.Include("Salary").Where(sl=>sl.Id == id).FirstOrDefault();
        }
    }
        
}
