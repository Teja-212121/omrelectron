
namespace Rio
{
    using Serenity.Services;
    using System;
    using System.Collections.Generic;

    public class ExcelImportRequest : ServiceRequest
    {
        public String FileName { get; set; }
        public Int32 ExamId { get; set; }

        /*public String ProductId { get; set; }

        public int stateId { get; set; }

        public int CustomerId { get; set; }
        public int ShippingProviderId { get; set; }
        public String SelectedName { get; set; }*/

        internal void CheckNotNull()
        {
            throw new NotImplementedException();
        }
    }

   

    public class ExcelImportResponse : ServiceResponse
    {
        public int Inserted { get; set; }
        public int Updated { get; set; }

        /*public String CustomerEmail1 { get; set; }
        public String CustomerEmail2 { get; set; }
        public String CustomerMobile1 { get; set; }
        public String CustomerMobile2 { get; set; }
        public String CustomerName { get; set; }
        public String ShippingAddress1 { get; set; }
        public String TrackingURL { get; set; }
        public String ShippingAddress2 { get; set; }
        public String GSTIN { get; set; }
        public String Pincode { get; set; }
        public String City { get; set; }
        public Int32 State { get; set; }
        public decimal TotalItemRate { get; set; }

        public float cost { get; set; }
        public decimal Amount { get; set; }*/
        public List<string> ErrorList { get; set; }
    }
}