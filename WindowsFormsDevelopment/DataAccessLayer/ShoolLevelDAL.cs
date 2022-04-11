using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class ShoolLevelDAL
    {
        private static ShoolLevelDAL instance;

        public static ShoolLevelDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShoolLevelDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private ShoolLevelDAL() { }

        
    }
}
