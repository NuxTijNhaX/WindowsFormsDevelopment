using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class FacultyDAL
    {
        private static FacultyDAL instance;

        public static FacultyDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FacultyDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private FacultyDAL() { }


    }
}
