using Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class ProductsValidation : AbstractValidator<ProductDTO>
    {
        public ProductsValidation()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
