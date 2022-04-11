using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class MajorDAL
    {
        private static MajorDAL instance;

        public static MajorDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MajorDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private MajorDAL() { }

        
    }
}
