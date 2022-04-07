using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class GradeSubjectClassDAL
    {
        private static GradeSubjectClassDAL instance;

        public static GradeSubjectClassDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GradeSubjectClassDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private GradeSubjectClassDAL() { }

        /// <summary>
        /// Kiểm tra điểm của môn học tiên quyết có >= 5
        /// </summary>
        /// <param name="preSubId">Mã môn học trước</param>
        /// <param name="studentId">Mã sinh viên</param>
        /// <returns>true nếu thỏa điều kiện, false nếu ngược lại</returns>
        public static bool CheckPrerequisiteSubject(string preSubId, string studentId)
        {
            bool result = true;

            try
            {
                using(var database = new UehDbContext())
                {
                    var data = (from subject in database.Subjects
                                where subject.Id == preSubId
                                join subClass in database.SubjectClasses
                                on subject.Id equals subClass.Subject_Id
                                join gradeSubClass in database.GradeSubjectClasses
                                on subClass.Id equals gradeSubClass.SubjectClassId
                                where gradeSubClass.StudentId == studentId
                                select gradeSubClass.Grade).ToList().Max();

                    if (data < 5.0F) return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    
        /// <summary>
        /// Kiểm tra với mã môn học này có tồn tại lớp học phần nào
        /// sinh viên đang đăng ký 
        /// </summary>
        /// <param name="subId">Mã môn học</param>
        /// <param name="studentId">Mã sinh viên</param>
        /// <returns>Empty String: nếu không tồn tại lớp học phần tương đương
        /// </returns>
        public static string CheckExistenceSubjectClass(string subId, string studentId)
        {
            string result = String.Empty;

            try
            {
                using (var database = new UehDbContext()) 
                {
                    var data = (from sub in database.Subjects
                               where sub.Id == subId
                               join subClass in database.SubjectClasses
                               on sub.Id equals subClass.Subject_Id
                               join gradeSubClass in database.GradeSubjectClasses
                               on subClass.Id equals gradeSubClass.SubjectClassId
                               where gradeSubClass.StudentId == studentId
                               select gradeSubClass).ToList();

                    foreach (var item in data)
                    {
                        if (item.Grade == null)
                            return item.SubjectClassId;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subClassId"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public static bool RegisterSubjectClass(string subClassId, string studentId)
        {
            bool result = false;

            try
            {
                using (var database = new UehDbContext()) 
                {
                    GradeSubjectClass gradeSubjectClass = new GradeSubjectClass()
                    {
                        SubjectClassId = subClassId,
                        StudentId = studentId
                    };

                    database.GradeSubjectClasses.Add(gradeSubjectClass);
                    database.SaveChanges();

                    result = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static bool ReRegisterSubjectClass(string preSubClass, string subClassId, string studentId)
        {
            bool result = false;

            try
            {
                using (var database = new UehDbContext())
                {
                    GradeSubjectClass graSubCla = (from gradeSubClass in database.GradeSubjectClasses
                                                   where gradeSubClass.SubjectClassId == preSubClass
                                                   && gradeSubClass.StudentId == studentId
                                                   select gradeSubClass).FirstOrDefault();
                    database.GradeSubjectClasses.Remove(graSubCla);

                    GradeSubjectClass newGraSubCla = new GradeSubjectClass()
                    {
                        SubjectClassId = subClassId,
                        StudentId = studentId
                    };

                    database.GradeSubjectClasses.Add(newGraSubCla);
                    database.SaveChanges();

                    result = true;
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
