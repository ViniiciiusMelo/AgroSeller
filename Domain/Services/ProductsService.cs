using Domain.Entity;
using Domain.Interfaces;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository _repository;

        public ProductsService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Create(Products entity)
        {
            return await _repository.Create(entity);
        }

        public Task<string> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<string> Get()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<string> Update()
        {
            throw new NotImplementedException();
        }
    }
}
