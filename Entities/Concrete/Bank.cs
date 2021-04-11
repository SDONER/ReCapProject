using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bank : IEntity
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ValidThru { get; set; }
        public string CvvCode { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }

    }
}
