using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoRE.Core.User
{
    interface IDataLocalService<T> where T : REObject
    {
        Task<T> Create(T entity);
        Task<bool> Delete(int id);
        Task<T> Update(int id, T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();

    }
}
