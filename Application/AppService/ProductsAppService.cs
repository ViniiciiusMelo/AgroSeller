using Application.DTOs;
using Application.Interfaces;
using Application.Validations;
using AutoMapper;
using Domain.Entity;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService
{
    public class ProductsAppService : IProductsAppService
    {
        private readonly IProductsService _productsService;
        private readonly IMapper _mapper;
        private readonly ProductsValidation validationRules;

        public ProductsAppService(IProductsService productsService, IMapper mapper)
        {
            _productsService = productsService;
            _mapper = mapper;
            validationRules = new ProductsValidation();
        }

        public async Task<string> Create(ProductDTO product)
        {

            try
            {
                //var result = validationRules.Validate(product);
                var entity = _mapper.Map<Products>(product);

                await _productsService.Create(entity);

                return null;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }





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
