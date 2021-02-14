using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Car : IEntities
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public int ModelYear { get; set; }  
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }


    }
}
