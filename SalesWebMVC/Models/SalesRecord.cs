using SalesWebMVC.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        
        public DateTime Date { get; set; }
        
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public int SaleId { get; set; } 
        public virtual Seller? Seller { get; set; }

        public SalesRecord()
        {
        }

        

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, int sellerId)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            SaleId = sellerId;
        }
    }

}
