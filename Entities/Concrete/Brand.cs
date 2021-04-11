using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string  BrandYear { get; set; }
    }
}
