using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebSystem.Models.Enums;

namespace SalesWebSystem.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus SalesStatus { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus salesStatus)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SalesStatus = salesStatus;
        }
    }
}
