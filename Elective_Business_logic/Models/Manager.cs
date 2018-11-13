using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective_Business_logic.Models
{
    public abstract class Manager<T>
    {
        public abstract List<T> Get_Data();
        public abstract void Add_Item(T item);
        public abstract void Delete_Item(T item);
    }
}
