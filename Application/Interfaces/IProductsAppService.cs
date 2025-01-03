﻿using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductsAppService
    {
        Task<string> Create(ProductDTO product);

        Task<string> Update();

        Task<string> Get();

        Task<string> GetList();

        Task<string> Delete();
    }
}
