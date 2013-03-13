using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Core.ViewModels.Common
{
    public class PropertyHistoryItem
    {
        public string LoanNumber { get; set; }
        public string WorkOrderNumber { get; set; }
        public string WorkOrderType { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? JobCompletionDate { get; set; }
        public DateTime? CompletionUploadDate { get; set; }
        public DateTime? BidDate { get; set; }
        public DateTime? BillDate { get; set; }
        public string BidNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public int ClientInvoiceAmount { get; set; }
        public int NumberOfPhotos { get; set; }
    }
}
