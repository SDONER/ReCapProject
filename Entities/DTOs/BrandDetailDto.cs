using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BrandDetailDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
    }
}
