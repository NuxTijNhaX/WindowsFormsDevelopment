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

        //public static List<object> GetSubjectsInforByUnPassList(List<string> unPassList, string semester)
        //{
        //    List<object> result;

        //    try
        //    {
        //        using (var database = new UehDbContext())
        //        {
        //            result = (from majorPro in database.MajorPrograms
        //                      where majorPro.Id == majorProgramId
        //                      join subjectPro in database.SubjectPrograms
        //                      on majorPro.Id equals subjectPro.MajorProgramId
        //                      where subjectPro.OnScheduleSemester == semester
        //                      join subject in database.Subjects
        //                      on subjectPro.SubjectId equals subject.Id
        //                      orderby subjectPro.OnScheduleSemester ascending // TODO: change
        //                      select new
        //                      {
        //                          Id = subject.Id,
        //                          Name = subject.Name,
        //                          PrerequisiteSubject = subject.PrerequisiteSubject,
        //                          OptionGroup = subjectPro.OptionGroup,
        //                          Credit = subject.Credit
        //                      }).ToList<object>();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return result;
        //}
    }
}
