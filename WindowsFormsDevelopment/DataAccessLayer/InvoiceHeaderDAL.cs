using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class InvoiceHeaderDAL
    {
        private static InvoiceHeaderDAL instance;

        public static InvoiceHeaderDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceHeaderDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private InvoiceHeaderDAL() { }

        public static bool AddInvoiceHeader(Guid invoiceHeaderId, string description,
            int totalCost, int payMedId, string studentId)
        {
            bool isSuccess = false;

            try
            {
                using (var db = new UehDbContext())
                {
                    InvoiceHeader invoiceHeader = new InvoiceHeader()
                    {
                        GuidInvoice = invoiceHeaderId,
                        Description = description,
                        PaidDay = DateTime.Now,
                        TotalCost = totalCost,
                        PaymentMehod_Id = payMedId,
                        Student_StudentId = studentId,
                    };

                    db.InvoiceHeaders.Add(invoiceHeader);
                    db.SaveChanges();

                    isSuccess = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isSuccess;
        }

        public static List<object> GetInvoiceHeaders(string studentId)
        {
            List<object> invoiceHeaders;

            try
            {
                using (var db = new UehDbContext())
                {
                    invoiceHeaders = (from invHeader in db.InvoiceHeaders
                                      where invHeader.Student_StudentId == studentId
                                      join payMe in db.PaymentMehods
                                      on invHeader.PaymentMehod_Id equals payMe.Id
                                      orderby invHeader.PaidDay descending
                                      select new
                                      {
                                          Id = invHeader.GuidInvoice,
                                          Des = invHeader.Description,
                                          Date = invHeader.PaidDay,
                                          Total = invHeader.TotalCost,
                                          Payment = payMe.Name,
                                      }).ToList<object>();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return invoiceHeaders;
        }
    }
}
