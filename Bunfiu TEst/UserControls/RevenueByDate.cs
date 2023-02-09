using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_App.UserControls
{
    public class RevenueByDate
    {
        public DateTime Date { get; set; }
        public decimal Revenue { get; set; }

        public RevenueByDate(DateTime date, decimal revenue)
        {
            Date = date;
            Revenue = revenue;
        }
    }
}
