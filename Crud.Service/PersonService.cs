
using Crud.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Service
{
    public class PersonService
    {       
            PersonContext personContext;
            public PersonService()
            {
                personContext = new PersonContext();

            }
            public IEnumerable<Person> GetPeople()
            {
            return personContext.People;
            }
    }
}
