using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class CampusDAL
    {
        private static CampusDAL instance;

        public static CampusDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CampusDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private CampusDAL() { }

        public static List<Campus> GetAllCampuses()
        {
            List<Campus> campuses = new List<Campus>();

            try
            {
                using (var db = new UehDbContext())
                {
                    campuses = (from camp in db.Campuses
                               select camp).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return campuses;
        }
    }
}
