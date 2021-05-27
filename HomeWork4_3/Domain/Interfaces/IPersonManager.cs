using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork4_3.Models;

namespace HomeWork4_3.Domain.Interfaces
{
    public interface IPersonManager
    {
        Person GetItem(int id);
        int Create(Person person);
    }
}
