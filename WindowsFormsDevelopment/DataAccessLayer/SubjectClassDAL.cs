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
                              on subClass.Lecturer_Id equals lecturer.Id
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
                                LecturerName = lecturer.FullName,
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
                              on subClass.Lecturer_Id equals lecturer.Id
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
                                  LecturerName = lecturer.FullName,
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
    }
}
