using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OctoRE.Core.User
{
    public class UserDataStorage<T> : IDataLocalService<T> where T : REObject
    {
        public async Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
