using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Services
{
    class PersonDataService : DataBaseServices<Person>
    {
        public static DataBaseServices<Person> Instance { get; } = new PersonDataService();
        public override IEnumerable<Person> Read()
        {
            if (IsOpen)
            {
                return new List<Person>()
                {
                    new Person(){FisrtName = "Евгений", LastName = "Малащук"},
                    new Person(){FisrtName = "Вася", LastName = "Пупкин"}
                };
            }

            return null;
        }

       
    }
}
