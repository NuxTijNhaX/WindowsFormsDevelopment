using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private AccountDAL() { }

        //static Func<string, string, UehDbContext, List<string>> GetAccess;

        //private static List<string> GetAccessLecturerRole(string username, string pass, UehDbContext db)
        //{
        //    List<string> result = new List<string>();

        //    var lecturerId = (from acc in db.Accounts
        //                      where acc.Email == username && acc.Password == pass
        //                      join lec in db.Lecturers
        //                      on acc.Email equals lec.Email
        //                      select lec.Id).FirstOrDefault();

        //    if (lecturerId is null)
        //    {
        //        result.Add("-1");
        //        result.Add("-1");
        //    }
        //    else
        //    {
        //        result.Add("1");
        //        result.Add(lecturerId);
        //    }

        //    return result;
        //}

        //private static List<string> GetAccessStudentRole(string username, string pass, UehDbContext db)
        //{
        //    List<string> result = new List<string>();

        //    var studentId = (from acc in db.Accounts
        //                     join stu in db.Students
        //                     on acc.Email equals stu.Email
        //                     where stu.Email == username && acc.Password == pass
        //                     select stu.Id).FirstOrDefault();

        //    if (studentId is null)
        //    {
        //        result.Add("-1");
        //        result.Add("-1");
        //    }
        //    else
        //    {
        //        result.Add("2");
        //        result.Add(studentId);
        //    }

        //    return result;
        //}

        //public static List<string> GetAccessInfor(string username, string pass)
        //{
        //    List<string> result = new List<string>();

        //    if (username.Contains("@st.ueh.edu.vn"))
        //        GetAccess = GetAccessStudentRole;
        //    else if (username.Contains("@ueh.edu.vn"))
        //        GetAccess = GetAccessLecturerRole;
        //    else if (username.Contains("@ad.ueh.edu.vn"))
        //    {

        //    }

        //    try
        //    {
        //        using (var database = new UehDbContext())
        //        {
        //            result = GetAccess(username, pass, database);
        //        }
        //    }
        //    catch (Exception)
        //    {
                
        //    }

        //    return result;
        //}

        public static string[] GetAccessInfor(string username, string pass)
        {
            string[] result = new string[2] { "-1", "-1" };

            try
            {
                using (var db = new UehDbContext())
                {
                    dynamic data = (from user in db.Users
                                    where user.Id == username || user.Email == username
                                    join acc in db.Accounts
                                    on user.Id equals acc.Id
                                    where acc.Password == pass
                                    select new
                                    {
                                        Id = user.Id,
                                        Email = user.Email
                                    }).FirstOrDefault();

                    if(data != null)
                    {
                        if (data.Email.Contains("@st.ueh.edu.vn"))
                            result[0] = "2";
                        else if (data.Email.Contains("@ueh.edu.vn"))
                            result[0] = "1";
                        else if (data.Email.Contains("@ad.ueh.edu.vn"))
                            result[0] = "0";

                        result[1] = data.Id;
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
