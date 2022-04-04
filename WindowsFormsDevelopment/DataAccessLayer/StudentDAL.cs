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
                using (var database = new UehDbContext())
                {
                    result = (from student in database.Students
                              where student.Id == studentId
                              join cla in database.Classes on student.Class_Id equals cla.Id
                              join majorPro in database.MajorPrograms on cla.MajorProgram_Id equals majorPro.Id
                              join major in database.Majors on majorPro.Major_Id equals major.Id
                              select new
                              {
                                  Id = student.Id,
                                  Name = student.FullName,
                                  Email = student.Email,
                                  PhoneNumber = student.PhoneNumber,
                                  Address = student.Address,
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
