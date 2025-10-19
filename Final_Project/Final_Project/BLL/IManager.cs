using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.BLL
{
    public interface IManager<T>
    {
        void Add(T obj);
        void Delete(T obj);
    }
}
