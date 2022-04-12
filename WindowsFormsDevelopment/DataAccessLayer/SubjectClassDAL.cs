using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class SubjectClassDAL
    {
        private static SubjectClassDAL instance;

        public static SubjectClassDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SubjectClassDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private SubjectClassDAL() { }

        public static List<object> GetSubjectClasses(string subjectId, int year, int phase)
        {
            List<object> result;

            try
            {
                using (var database = new UehDbContext())
                {
                    result = (from subClass in database.SubjectClasses
                              where subClass.Subject_Id == subjectId
                              && subClass.Year == year
                              && subClass.Semester == phase
                              join subject in database.Subjects
                              on subClass.Subject_Id equals subject.Id
                              join lecturer in database.Lecturers
                              on subClass.LecturerId equals lecturer.LecturerId
                              join user in database.Users
                              on lecturer.LecturerId equals user.Id
                              join room in database.Rooms
                              on subClass.Room_Id equals room.Id
                              join shift in database.Shifts
                              on subClass.Shift_Id equals shift.Id
                              select new 
                              { 
                                Id = subClass.Id,
                                Name = subject.Name,
                                BeginDate = subClass.BeginDate,
                                EndDate = subClass.EndDate,
                                Room = room.Id,
                                LecturerName = user.FullName,
                                Shift = shift.Description,
                              }).ToList<object>();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public static object GetSubjectClass(string subjectClassId)
        {
            object result;

            try
            {
                using (var database = new UehDbContext())
                {
                    result = (from subClass in database.SubjectClasses
                              where subClass.Id == subjectClassId
                              join subject in database.Subjects
                              on subClass.Subject_Id equals subject.Id
                              join lecturer in database.Lecturers
                              on subClass.LecturerId equals lecturer.LecturerId
                              join user in database.Users
                              on lecturer.LecturerId equals user.Id
                              join room in database.Rooms
                              on subClass.Room_Id equals room.Id
                              join shift in database.Shifts
                              on subClass.Shift_Id equals shift.Id
                              select new
                              {
                                  Id = subClass.Id,
                                  Name = subject.Name,
                                  BeginDate = subClass.BeginDate,
                                  EndDate = subClass.EndDate,
                                  Room = room.Id,
                                  LecturerName = user.FullName,
                                  Shift = shift.Description,
                                  Credit = subject.Credit,
                              }).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }
    
        public static int CountSubjectClass(string subjectId, int year, int phase)
        {
            return GetSubjectClasses(subjectId, year, phase).Count;
        }

        public static bool AddSubjectClass(SubjectClass subjectClass)
        {
            bool isSuccess = false;

            try
            {
                using (var db = new UehDbContext())
                {
                    db.SubjectClasses.Add(subjectClass);
                    db.SaveChanges();

                    isSuccess = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return isSuccess;
        }

        public static List<object> GetSubjectClasses(string classId, string subjectId)
        {
            List<object> result = new List<object>();

            try
            {
                using (var db = new UehDbContext())
                {
                    var allSubClasses = (from subClass in db.SubjectClasses
                                         where subClass.Class_Id == classId
                                         && subClass.Subject_Id == subjectId
                                         select subClass.Id).ToList<string>();

                    foreach (var item in allSubClasses)
                    {
                        result.Add(GetSubjectClass(item));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static bool DeleteSubjectClass(string subClassId)
        {
            bool result = false;

            using (var db = new UehDbContext())
            {
                var subClass = (from subcla in db.SubjectClasses
                                where subcla.Id == subClassId
                                select subcla).FirstOrDefault();

                db.SubjectClasses.Remove(subClass);
                db.SaveChanges();

                result = true;
            }

            return result;
        }

        public static bool IsHavingStudentAttended(string subClassId)
        {
            bool result = false;

            using (var db = new UehDbContext())
            {
                var countAttender = (from subcla in db.SubjectClasses
                                     where subcla.Id == subClassId
                                     join gra in db.GradeSubjectClasses
                                     on subcla.Id equals gra.SubjectClassId
                                     select gra).ToList().Count();

                if (countAttender > 0) return true;
            }

            return result;
        }
    }
}
