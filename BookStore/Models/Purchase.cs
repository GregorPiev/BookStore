using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchase
    {
        //Id purchase
        public int PurchaseId { get; set; }
        //First ans Last name of customer
        public string Person { get; set; }
        //Person address
        public string Address { get; set; }
        //Book id
        public int BookId { get; set; }
        //Purchase Date
        public DateTime Date { get; set; }
    }
}