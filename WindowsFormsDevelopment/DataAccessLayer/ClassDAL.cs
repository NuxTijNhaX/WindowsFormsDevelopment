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

        public static List<Class> GetClasses()
        {
            List<Class> classes = new List<Class>();

            try
            {
                using (var db = new UehDbContext())
                {
                    classes = (from cla in db.Classes
                               select cla).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return classes;
        }

        public static List<Class> GetClasses(string majorId)
        {
            List<Class> classes = new List<Class>();

            try
            {
                using (var db = new UehDbContext())
                {
                    classes = (from majPro in db.MajorPrograms
                               where majPro.Major_Id == majorId
                               join cla in db.Classes
                               on majPro.Id equals cla.MajorProgram_Id
                               select cla).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return classes;
        }
    }
}
