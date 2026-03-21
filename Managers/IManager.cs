
using System;
using System.Collections.Generic;
using System.Text;

namespace LabHotelManagment
{
    public interface IManager<T>
    {
        T GetOne(object ID);
        List<T> GetAll();
        bool Update(T item);
        bool Add(T item);
        bool Delete(object ID);

    }
}
