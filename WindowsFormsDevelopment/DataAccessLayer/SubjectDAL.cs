using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class SubjectDAL
    {
        private static SubjectDAL instance;

        public static SubjectDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SubjectDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private SubjectDAL() { }

        public static List<Subject> GetSubjectsInforByMajorProgram(string majorProgramId)
        {
            List<Subject> result; // = new List<Subject>();

            try
            {
                using (var database = new UehDbContext())
                {
                    result = (from majorPro in database.MajorPrograms
                              where majorPro.Id == majorProgramId
                              join subjectPro in database.SubjectPrograms
                              on majorPro.Id equals subjectPro.MajorProgramId
                              join subject in database.Subjects
                              on subjectPro.SubjectId equals subject.Id
                              select subject).ToList();
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
