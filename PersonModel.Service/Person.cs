using Person.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonModel.Service
{
    class Person
    {
        PersonContext personContext;
        public Person()
        {
            personContext = new PersonContext();

        }
       
    }
}
