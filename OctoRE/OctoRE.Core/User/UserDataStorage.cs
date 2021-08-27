using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OctoRE.Core.User
{
    public class UserDataStorage<T> : IDataLocalService<T> where T : REObject
    {
        public async Task<T> Create(T entity)
        {
            T task = await Wha();
            return task;
        }

        public async Task<bool> Delete(int id)
        {
            await Wha();
            return true;
        }

        public async Task<T> Get(int id)
        {
            T task = await Wha();
            return task;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            await Wha();
            return null;
        }

        public async Task<T> Update(int id, T entity)
        {
            T task = await Wha();
            return task;
        }

        private static async Task<T> Wha()
        {
            var wha = 0;
            for (var index = 0; index <= 25; index++)
            {
                wha++;
                if (wha%5 == 0)
                {
                    await Task.Delay(10);
                }
            }

            return null;
        }
    }
}
