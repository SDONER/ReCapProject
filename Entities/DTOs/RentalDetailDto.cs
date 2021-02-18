using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int BrandId { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }

        public int UserID { get; set; }
        public string CompanyName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
