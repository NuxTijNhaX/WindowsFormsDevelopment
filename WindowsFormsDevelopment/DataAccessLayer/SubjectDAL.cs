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

        public static List<object> GetSubjectsInforByMajorProgram(string majorProgramId, string semester)
        {
            List<object> result;

            try
            {
                using (var database = new UehDbContext())
                {
                    result = (from majorPro in database.MajorPrograms
                              where majorPro.Id == majorProgramId
                              join subjectPro in database.SubjectPrograms
                              on majorPro.Id equals subjectPro.MajorProgramId
                              where subjectPro.OnScheduleSemester == semester
                              join subject in database.Subjects
                              on subjectPro.SubjectId equals subject.Id
                              orderby subjectPro.OnScheduleSemester ascending // TODO: change
                              select new 
                              { 
                                Id = subject.Id,
                                Name = subject.Name,
                                PrerequisiteSubject = subject.PrerequisiteSubject,
                                OptionGroup = subjectPro.OptionGroup,
                                Credit = subject.Credit
                              }).ToList<object>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static List<object> GetSubjectsInforByUnPassList(List<string> unPassList, string majorProgramId)
        {
            List<object> result = new List<object>();

            try
            {
                using (var database = new UehDbContext())
                {
                    foreach (string subId in unPassList)
                    {
                        var subject = (from majorPro in database.MajorPrograms
                                       where majorPro.Id == majorProgramId
                                       join subPro in database.SubjectPrograms
                                       on majorPro.Id equals subPro.MajorProgramId
                                       join sub in database.Subjects
                                       on subPro.SubjectId equals sub.Id
                                       where sub.Id == subId
                                       select new
                                       {
                                           Id = sub.Id,
                                           Name = sub.Name,
                                           PrerequisiteSubject = sub.PrerequisiteSubject,
                                           OptionGroup = subPro.OptionGroup,
                                           Credit = sub.Credit
                                       }).FirstOrDefault();

                        result.Add(subject);
                    }
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
