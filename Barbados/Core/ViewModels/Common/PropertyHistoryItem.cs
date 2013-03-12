using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DALServices.ViewModels.Common
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

        public string LoanNumberLabel { get; set; }
        public string WorkOrderNumberLabel { get; set; }
        public string WorkOrderTypeLabel { get; set; }
        public string OrderDateLabel { get; set; }
        public string JobCompletionDateLabel { get; set; }
        public string CompletionUploadDateLabel { get; set; }
        public string BidDateLabel { get; set; }
        public string BillDateLabel { get; set; }
        public string BidNumberLabel { get; set; }
        public string InvoiceNumberLabel { get; set; }
        public string ClientInvoiceAmountLabel { get; set; }
        public string NumberOfPhotosLabel { get; set; }
    }
}
