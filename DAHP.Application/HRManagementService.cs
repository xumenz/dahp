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

//Employee
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

        //Employment
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

        public Guid createProfessionalQualification(ProfessionalQualification ProfessionalQualification)
        {

            context.ProfessionalQualifications.Add(ProfessionalQualification);
            context.SaveChanges();

            return ProfessionalQualification.Id;
        }


        public IList<ProfessionalQualification> ProfessionalQUalification()
        {
            return context.ProfessionalQualifications.ToList();
        }


        public ProfessionalQualification GetProfessionalQualification(Guid id)
        {
            return context.ProfessionalQualifications.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();

        }


        public Guid createQuery(Query Query)
        {

            context.Queries.Add(Query);
            context.SaveChanges();

            return Query.Id;
        }


        public IList<Query> GetQuery()
        {
            return context.Queries.ToList();
        }


        public Query GetQuery(Guid id)
        {
            return context.Queries.Include("Person").Where(ps => ps.Id == id).FirstOrDefault();

            //context.Queries.Include(qr => qr.EmployementInfo.Person);
        }


        public Guid createQueryGenerator(QueryGenerator QueryGenerator)
        {  

            context.QueryGenerators.Add(QueryGenerator);
            context.SaveChanges();

            return QueryGenerator.Id;
        }


        public IList<QueryGenerator> GetQueryGenerator()
        {
            return context.QueryGenerators.ToList();
        }


       
//Unit
        public Guid createUnit(Unit Unit)
        {
            Unit.Id = Guid.NewGuid();
            context.Units.Add(Unit);
            context.SaveChanges();

            return Unit.Id;
        }


        public IList<Unit> GetUnit()
        {
            return context.Units.ToList();
        }


        public Unit GetUnit(Guid id)
        {
            return context.Units.Include("person").Where(ps => ps.Id == id).FirstOrDefault();

        }

        public IList<Unit> GetUnitByDepartment(Guid departmentId)
        {
            return context.Units.Where(un => un.DepartmentId == departmentId).ToList();
        }

        //Department

        public Guid createDepartment(Department Department)
        {
            Department.Id = Guid.NewGuid();
            context.Departments.Add(Department);
            context.SaveChanges();

            return Department.Id;
        }


        public IList<Department> GetDepartment()
        {
            return context.Departments.ToList();
        }


        public Department GetDepartment(Guid id)
        {
            return context.Departments.Include("person").Where(ps => ps.Id == id).FirstOrDefault();
        }

        // Department History
        public Guid createDepartmentHeadHistory(DepartmentHeadHistory DepartmentHeadHistory)
        {

            context.DepartmentHeadHistorys.Add(DepartmentHeadHistory);
            context.SaveChanges();

            return DepartmentHeadHistory.Id;
        }


        public IList<DepartmentHeadHistory> GetDepartmentHeadHistory()
        {
            return context.DepartmentHeadHistorys.ToList();
        }


        public DepartmentHeadHistory DepartmentHeadHistory(Guid id)
        {
            return context.DepartmentHeadHistorys.Include("person").Where(ps => ps.Id == id).FirstOrDefault();
        }

    }
}
