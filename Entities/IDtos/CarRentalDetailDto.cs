using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IDtos
{
    public class CarRentalDetailDto:IDto
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int ModelYear { get; set; }


        public decimal DailyPrice { get; set; }


        public string CustomerFName { get; set; }
        public string CustomerLName { get; set; }
        public string CustomerCompanyName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }


        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
