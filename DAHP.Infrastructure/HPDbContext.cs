using DAHP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Infrastructure
{
    public class HPDbContext : DbContext
    {
        public HPDbContext():base("name=HPDbContext")
        {

        }


        public DbSet<Person> Persons { get; set; }


    }
}
