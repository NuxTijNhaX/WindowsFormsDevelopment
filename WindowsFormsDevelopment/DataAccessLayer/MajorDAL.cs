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

        public static List<Major> GetMajors(string facultyId)
        {
            List<Major> majors = new List<Major>();

            try
            {
                using (var db = new UehDbContext())
                {
                    majors = (from maj in db.Majors
                              join majPro in db.MajorPrograms
                              on maj.Id equals majPro.Major_Id
                              join fac in db.Faculties
                              on majPro.Faculty_Id equals fac.Id
                              where fac.Id == facultyId
                              select maj).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return majors;
        }
    }
}
