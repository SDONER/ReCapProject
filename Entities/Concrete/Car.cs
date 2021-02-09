﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Car : IEntities
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }


        
    }
}