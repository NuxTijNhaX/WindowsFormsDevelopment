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
    }
}
