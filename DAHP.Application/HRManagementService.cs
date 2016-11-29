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
            return context.EmployeeCategorys.Include("Person").Where(pl=>pl.Id == id).FirstOrDefault();
        }


        public Guid createEmployeeSalaryInfo(EmployeeSalaryInfo EmployeeSalaryInfo)
        {

            context.EmployeeSalaryInfos.Add(EmployeeSalaryInfo);
            context.SaveChanges();

            return EmployeeSalaryInfo.Id;
        }


        public IList<EmployeeSalaryInfo> GetEmployeeInfos()
        {
            return context.EmployeeSalaryInfos.ToList();
        }


        public EmployeeSalaryInfo GetEmployeeSalary(Guid id)
        {
            return context.EmployeeSalaryInfos.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();
        }

        //public Guid createEmployeeType(EmployeeType EmployeeType)
        //{

        //    context.EmployeeTypes.Add(EmployeeType);
        //    context.SaveChanges();

        //    return EmployeeType.Id;
        //}


        //public IList<EmployeeType> GetEmployeeTypes()
        //{
        //    return context.EmployeeTypes.ToList();
        //}


        //public EmployeeType GetEmployeType(Guid id)
        //{
        //    return context.EmployeeTypes.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();
        //}

        public Guid createEmploymentHistory(EmploymentHistory EmploymentHistory)
        {

            context.EmploymentHistorys.Add(EmploymentHistory);
            context.SaveChanges();

            return EmploymentHistory.Id;
        }


        public IList<EmploymentHistory> GetEmploymentHistory()
        {
            return context.EmploymentHistorys.ToList();
        }


        public EmploymentHistory GetEmploymentHistory(Guid id)
        {
            return context.EmploymentHistorys.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();

        }


               public Guid createGradeLevel(GradeLevel GradeLevel)
        {

            context.GradeLevels.Add(GradeLevel);
            context.SaveChanges();

            return GradeLevel.Id;
        }


        public IList<GradeLevel> GetGradeLevel()
        {
            return context.GradeLevels.ToList();
        }


        public GradeLevel GetGradeLevel(Guid id)
        {
            return context.GradeLevels.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();

        }

        public Guid createJobHistory(JobHistory JobHistory)
        {

            context.JobHistorys.Add(JobHistory);
            context.SaveChanges();

            return JobHistory.Id;
        }


        public IList<JobHistory> JobHistory()
        {
            return context.JobHistorys.ToList();
        }


        public JobHistory GetJobHistory(Guid id)
        {
            return context.JobHistorys.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();

        }


        public Guid createLevelDetail(LevelDetail LevelDetail)
        {

            context.LevelDetails.Add(LevelDetail);
            context.SaveChanges();

            return LevelDetail.Id;
        }


        public IList<LevelDetail> LevelDetail()
        {
            return context.LevelDetails.ToList();
        }


        public LevelDetail GetLevelDetail(Guid id)
        {
            return context.LevelDetails.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();

        }

    }
}
