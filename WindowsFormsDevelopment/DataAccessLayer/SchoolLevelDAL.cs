using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class SchoolLevelDAL
    {
        private static SchoolLevelDAL instance;

        public static SchoolLevelDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SchoolLevelDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private SchoolLevelDAL() { }

        public static List<SchoolLevel> GetAllSchoolLevel()
        {
            List<SchoolLevel> schoolLevels = new List<SchoolLevel>();

            try
            {
                using (var db = new UehDbContext())
                {
                    schoolLevels = (from schlev in db.SchoolLevels
                                    select schlev).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return schoolLevels;
        }
    }
}
