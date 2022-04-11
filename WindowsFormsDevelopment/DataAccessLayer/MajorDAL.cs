using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class ClassDAL
    {
        private static ClassDAL instance;

        public static ClassDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClassDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private ClassDAL() { }

        
    }
}
