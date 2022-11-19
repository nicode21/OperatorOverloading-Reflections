using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Models;
using Training.Services.Interfaces;

namespace Training.Services
{
    public class PersonService : IPersonService
    {
        public int GetFilteredDatasCount(Predicate<Person> predicate)
        {
            var datas = GetAll();

            var filteredDatas = datas.FindAll(predicate);

            double result = Math.Pow(filteredDatas.Count,2);

            return (int)result;
        }

        public List<string> GetFullData(Predicate<Person> predicate)
        {

            List<Person> people = GetAll();

            var result = people.FindAll(predicate);

            return GetPersonDetails(result);

        }

        private List<Person> GetAll()
        {
            List<Person> people = new List<Person>();

            Person person1 = new()
            {
                Name = "Cesul",
                Surname = "Hesenov",
                Adress = "Ehmedli",
                Salary = 400
            };
            Person person2 = new()
            {
                Name = "Novreste",
                Surname = "Aslanzade",
                Adress = "Azadliq",
                Salary = 700
            };
            Person person3 = new()
            {
                Name = "coshqar",
                Surname = "Nerimanli",
                Adress = "Ehmedli",
                Salary = 8000
            };
            Person person4 = new()
            {
                Name = "lale",
                Surname = "Quliyeva",
                Adress = "Nesimi",
                Salary = 2000
            };
            Person person5 = new()
            {
                Name = "Gultac",
                Surname = "Ceferova",
                Adress = "Tiblis",
                Salary = 10000
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;
        }

        private List<string> GetPersonDetails(List<Person> list)
        {
            List<string> fullDatas = new();

            foreach (var item in list)
            {
                string data = $"{item.Name} - {item.Surname} - {item.Adress}";

                fullDatas.Add(data);
            }

            return fullDatas;
        }
    }
}
