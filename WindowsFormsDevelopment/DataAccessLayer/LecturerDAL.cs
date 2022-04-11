using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class LecturerDAL
    {
        private static LecturerDAL instance;

        public static LecturerDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LecturerDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private LecturerDAL() { }

        public static List<Lecturer> GetLecturers(string subjectId)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            try
            {
                using (var db = new UehDbContext())
                {
                    string subLecturer = (from sub in db.Subjects
                                           where sub.Id == subjectId
                                           select sub.SubjectLecturer).FirstOrDefault();

                    string[] lecturerList = subLecturer.Split(',');

                    foreach (var lecturer in lecturerList)
                    {
                        lecturers.Add(GetLecturer(lecturer));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lecturers;
        }

        public static Lecturer GetLecturer(string lecturerId)
        {
            Lecturer lecturer;

            try
            {
                using (var db = new UehDbContext())
                {
                    lecturer = (from lec in db.Lecturers
                                where lec.LecturerId == lecturerId
                                select lec).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return lecturer;
        }
    }
}
