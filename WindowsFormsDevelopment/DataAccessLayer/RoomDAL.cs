using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class RoomDAL
    {
        private static RoomDAL instance;

        public static RoomDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private RoomDAL() { }

        public static List<Room> GetRoom(string campusId)
        {
            List<Room> rooms = new List<Room>();

            try
            {
                using (var db = new UehDbContext())
                {
                    rooms = (from room in db.Rooms
                             where room.Campus_Id == campusId
                             select room).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return rooms;
        }
    }
}
