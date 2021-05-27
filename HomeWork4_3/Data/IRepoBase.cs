using System;
using System.Collections.Generic;

namespace Timesheets.Data
{
    public interface IRepoBase<T>
    {
        T GetItem(int id);
        IEnumerable<T> GetItems();
        void Add(T item);
        void Update();
    }
}