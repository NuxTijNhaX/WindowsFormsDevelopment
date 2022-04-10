using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
