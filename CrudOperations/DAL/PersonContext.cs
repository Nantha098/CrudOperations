using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CrudOperations.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext():base("PersonContext")
        {
            Database.SetInitializer<PersonContext>(new PersonInitializer());
            //Database.SetInitializer<PersonContext>(new CreateDatabaseIfNotExists<PersonContext>());
        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class PersonInitializer : DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var person = new List<Person>
            {
                new Person{PersonID= 1,Name="Nantha",PhoneNumber="9989899009",Email="nantha@gmail.com"},
                new Person{PersonID= 2,Name="Bala",PhoneNumber="7869875463",Email="bala@gmail.com"},
                new Person{PersonID= 3,Name="Sky",PhoneNumber="7654879643",Email="sky@gmail.com"},
                new Person{PersonID= 4,Name="June",PhoneNumber="89757896479",Email="june@gmail.com"}
            };
            person.ForEach(p => context.Persons.Add(p));
            context.SaveChanges();
        }
    }

}