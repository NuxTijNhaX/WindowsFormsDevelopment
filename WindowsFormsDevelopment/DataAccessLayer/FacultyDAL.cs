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

        public static List<Faculty> GetAllFaculty()
        {
            List<Faculty> faculties = new List<Faculty>();

            try
            {
                using (var db = new UehDbContext())
                {
                    faculties = (from fac in db.Faculties
                                 select fac).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return faculties;
        }
    }
}
