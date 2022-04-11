using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class ShiftDAL
    {
        private static ShiftDAL instance;

        public static ShiftDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShiftDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private ShiftDAL() { }

        public static List<Shift> GetShifts()
        {
            List<Shift> shifts = new List<Shift>();

            try
            {
                using (var db = new UehDbContext())
                {
                    shifts = (from shi in db.Shifts
                              select shi).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return shifts;
        }
    }
}
