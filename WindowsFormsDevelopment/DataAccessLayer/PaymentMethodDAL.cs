using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class PaymentMethodDAL
    {
        private static PaymentMethodDAL instance;

        public static PaymentMethodDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaymentMethodDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private PaymentMethodDAL() { }

        public static int GetPaymentMethodId(string paymentMethodName)
        {
            int paymentId;

            try
            {
                using (var db = new UehDbContext())
                {
                    paymentId = (from payment in db.PaymentMehods
                                 where payment.Name == paymentMethodName
                                 select payment.Id).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paymentId;
        }
    }
}
