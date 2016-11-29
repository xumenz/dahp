using DAHP.Domain;
using DAHP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Application
{
    public class EmployeeManagementService
    {
        HPDbContext context;

        public EmployeeManagementService()
        {
            context = new HPDbContext();
        }
        public Guid createPerson(Person person)
        {
            
            context.Persons.Add(person);
            context.SaveChanges();

            return person.Id;
        }


        public IList<Person> GetPersons()
        {
            return context.Persons.ToList();
        }


        public Person GetPerson(Guid id)
        {
            return context.Persons.Find(id);
        }





        public Guid createEmploymentInfo(EmploymentInfo EmploymentInfo)
        {

            context.EmploymentInfos.Add(EmploymentInfo);
            context.SaveChanges();

            return EmploymentInfo.Id;
        }


        public IList<EmploymentInfo> GetEmploymentInfos()
        {
            return context.EmploymentInfos.ToList();
        }


        public EmploymentInfo GetEmploymentInfo(Guid id)
        {
            return context.EmploymentInfos.Include("Person").Where(ps=>ps.Id == id).FirstOrDefault();
        }
    }
}
