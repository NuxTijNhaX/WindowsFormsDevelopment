using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class StudentDAL
    {
        private static StudentDAL instance;

        public static StudentDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private StudentDAL() { }

        public static object GetStudentInfor(string studentId)
        {
            object result;

            try
            {
                using (var db = new UehDbContext())
                {
                    result = (from stu in db.Students
                              where stu.StudentId == studentId
                              join user in db.Users
                              on stu.StudentId equals user.Id
                              join cla in db.Classes on stu.Class_Id equals cla.Id
                              join majorPro in db.MajorPrograms on cla.MajorProgram_Id equals majorPro.Id
                              join major in db.Majors on majorPro.Major_Id equals major.Id
                              select new
                              {
                                  Id = user.Id,
                                  Name = user.FullName,
                                  Email = user.Email,
                                  PhoneNumber = user.PhoneNumber,
                                  Address = user.Address,
                                  ClassId = cla.Id,
                                  Year = cla.Year,
                                  Major = major.Name,
                                  MajorProgramName = majorPro.Name,
                                  MajorProgramId = majorPro.Id
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
