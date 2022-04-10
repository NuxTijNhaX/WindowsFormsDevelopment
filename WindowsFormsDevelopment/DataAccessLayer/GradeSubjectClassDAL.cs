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
                    DeleteSubjectClass(preSubClass, studentId);

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
    
        public static bool DeleteSubjectClass(string subClassId, string studentId)
        {
            bool result = false;

            using (var database = new UehDbContext())
            {
                GradeSubjectClass graSubCla = (from gra in database.GradeSubjectClasses
                                               where gra.SubjectClassId == subClassId
                                               && gra.StudentId == studentId
                                               select gra).FirstOrDefault();
                
                database.GradeSubjectClasses.Remove(graSubCla);
                database.SaveChanges();

                result = true;
            }

            return result;
        }

        public static List<string> GetUnPassSubjects(string studentId)
        {
            List<string> results = new List<string>();

            try
            {
                using (var database = new UehDbContext())
                {
                    results = (from gra in database.GradeSubjectClasses
                               where gra.StudentId == studentId && gra.Grade < 5.0F
                               join subClass in database.SubjectClasses
                               on gra.SubjectClassId equals subClass.Id
                               select subClass.Subject_Id).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return results;
        }
    
        /// <summary>
        /// Lấy danh sách lớp học phần đã đăng ký và đã đóng học phí
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="year"></param>
        /// <param name="phase"></param>
        /// <returns></returns>
        public static List<object> GetRegisteredClasses(string studentId, int year, int phase)
        {
            List<object> result = new List<object>();

            try
            {
                using (var database = new UehDbContext()) 
                {
                    var allSubClasses = (from gra in database.GradeSubjectClasses
                                         where gra.StudentId == studentId
                                         && gra.Grade == null
                                         join subClass in database.SubjectClasses
                                         on gra.SubjectClassId equals subClass.Id
                                         where subClass.Year == year
                                         && subClass.Semester == phase
                                         select gra.SubjectClassId).ToList<string>();

                    var paidSubClasses = InvoiceDetailDAL.GetPaidSubjectClasses(studentId);

                    var datas = allSubClasses.Except(paidSubClasses);

                    foreach (var item in datas)
                    {
                        result.Add(SubjectClassDAL.GetSubjectClass(item));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static int GetTotalTuition(string studentId, int year, int phase, int totalCredits)
        {
            int result = 0;

            dynamic registeredClasses = GetRegisteredClasses(studentId, year, phase);

            foreach (var regClass in registeredClasses)
            {
                result += regClass.Credit;
            }

            return result * totalCredits;
        }
    }
}
