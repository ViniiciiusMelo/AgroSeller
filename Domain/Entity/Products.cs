using Domain.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Products : BaseEntity
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal Value { get; set; }

        public ClassificationEnum Classification { get; set; }

        public string? Package { get; set; }
    }
}
