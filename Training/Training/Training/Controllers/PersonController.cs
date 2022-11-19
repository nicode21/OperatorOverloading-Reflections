using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Services.Interfaces;
using Training.Services;

namespace Training.Controllers
{
    public class PersonController
    {
        public static void GetPersonDatas()
        {
            IPersonService personService = new PersonService();

            var result = personService.GetFullData(m => m.Salary > 1000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetFilteredPersonsPowCount()
        {
            IPersonService personService = new PersonService();

            Console.WriteLine(personService.GetFilteredDatasCount(m=>m.Name.ToLower().StartsWith("C".ToLower())));
        }

    }

}
