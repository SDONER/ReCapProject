using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarImageDetailDto : IDto
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public byte ImagerPath { get; set; }
        public DateTime? Date { get; set; }
    }
}
