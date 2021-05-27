using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork4_3.Domain.Interfaces;
using HomeWork4_3.Models;

namespace HomeWork4_3.Domain.Implementation
{
    public class PersonManager: IPersonManager
    {
        private readonly IPersonRepo _personRepo;

        public PersonManager(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }

        public Person GetItem(int id)
        {
            return _personRepo.GetItem(id);
        }

        public int Create(Person personRequest)
        {
            var person = new Person()
            {
                Id = personRequest.Id,
                FirstName = personRequest.FirstName,
                LastName = personRequest.LastName,
                Email = personRequest.Email,
                Company = personRequest.Company,
                Age = personRequest.Age
            };

            _personRepo.Add(person);

            return person.Id;
        }
    }
}
