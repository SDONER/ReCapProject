using Core.Entities;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Customer : IEntity
    {
        //[Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }

    }
}
