using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductsService
    {
        Task<string> Create(Products entity);

        Task<string> Update();

        Task<string> Get();

        Task<string> GetList();

        Task<string> Delete();
    }
}
