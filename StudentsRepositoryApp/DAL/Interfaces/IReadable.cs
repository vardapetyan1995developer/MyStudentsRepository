using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRepositoryApp.DAL.Interfaces
{
    public interface IReadable<T>
    {
        T GetItem(int id);
        IList<T> GetItems();
    }
}
