using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IBaseRepository<T>
    {
        Task<string> Create(T entity);

        Task<string> Update();

        Task<string> Get();

        Task<string> GetList();

        Task<string> Delete();
    }
}
