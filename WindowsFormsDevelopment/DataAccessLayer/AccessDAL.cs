using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class AccessDAL
    {
        private static AccessDAL instance;

        public static AccessDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccessDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private AccessDAL() { }

        static Func<string, string, UehDbContext, List<string>> GetAccess;

        private static List<string> GetAccessLecturerRole(string username, string pass, UehDbContext db)
        {
            List<string> result = new List<string>();

            var lecturerId = (from acc in db.Accounts
                              join lec in db.Lecturers
                              on acc.Email equals lec.Email
                              where lec.Email == username && acc.Password == pass
                              select lec.Id).FirstOrDefault();
            
            if(lecturerId is null)
            {
                result.Add("-1");
                result.Add("-1");
            } else
            {
                result.Add("1");
                result.Add(lecturerId);
            }

            return result;
        }

        private static List<string> GetAccessStudentRole(string username, string pass, UehDbContext db)
        {
            List<string> result = new List<string>();

            var studentId = (from acc in db.Accounts
                             join stu in db.Students
                             on acc.Email equals stu.Email
                             where stu.Email == username && acc.Password == pass
                             select stu.Id).FirstOrDefault();

            if (studentId is null)
            {
                result.Add("-1");
                result.Add("-1");
            }
            else
            {
                result.Add("2");
                result.Add(studentId);
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pass"></param>
        /// <returns>
        /// First element in List is:
        /// *-1 : Invalid
        ///  *0 : Admin role
        ///  *1 : Lecturer role
        ///  *2 : Student role;
        ///  Second element in List is userId
        /// </returns>
        public static List<string> GetAccessInfor(string username, string pass)
        {
            List<string> result = new List<string>();

            if (username.Contains("@st.ueh.edu.vn"))
                GetAccess = GetAccessStudentRole;
            else if (username.Contains("@ueh.edu.vn"))
                GetAccess = GetAccessLecturerRole;
            else if (username.Contains("@ad.ueh.edu.vn"))
            {

            }

            try
            {
                using (var database = new UehDbContext())
                {
                    result = GetAccess(username, pass, database);
                }
            }
            catch (Exception)
            {
                
            }

            return result;
        }
    }
}
