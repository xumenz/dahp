using DAHP.Domain;
using DAHP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Application
{
    public class HRManagementService
    {
        HPDbContext context;

        public HRManagementService()
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

        

        public Guid createDesignation(Designation Designation)
        {

            context.Designations.Add(Designation);
            context.SaveChanges();

            return Designation.Id;
        }


        public IList<Designation> GetDesignation()
        {
            return context.Designations.ToList();
        }


        public Designation GetDesignation(Guid id)
        {
            return context.Designations.Include("Person").Where(ps=>ps.Id == id).FirstOrDefault();
        }


          public Guid createEducation(Education Education)
        {

            context.Educations.Add(Education);
            context.SaveChanges();

            return Education.Id;
        }


        public IList<Education> GetEducation()
        {
            return context.Educations.ToList();
        }


        public Education GetEducation(Guid id)
        {
            return context.Educations.Include("Person").Where(ps=>ps.Id == id).FirstOrDefault();
        }

        public Guid createEmployeeCategory(EmployeeCategory EmployeeCategory)
        {

            context.EmployeeCategorys.Add(EmployeeCategory);
            context.SaveChanges();

            return EmployeeCategory.Id;
        }


        public IList<EmployeeCategory> GetEmployeeCategories()
        {
            return context.EmployeeCategorys.ToList();
        }


        public EmployeeCategory GetEmployeeCategory(Guid id)
        {
            return context.EmployeeCategorys.Include("Person").Where(ps=>ps.Id == id).FirstOrDefault();
        }


        public Guid createEmployeeCategory(EmployeeCategory EmployeeCategory)
        {

            context.EmployeeCategorys.Add(EmployeeCategory);
            context.SaveChanges();

            return EmployeeCategory.Id;
        }


        public IList<EmployeeCategory> GetEmployeeCategories()
        {
            return context.EmployeeCategorys.ToList();
        }


        public EmployeeCategory GetEmployeeCategory(Guid id)
        {
            return context.EmployeeCategorys.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();
        }

    }
}
