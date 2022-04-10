using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.DataAccessLayer
{
    public class InvoiceDetailDAL
    {
        private static InvoiceDetailDAL instance;

        public static InvoiceDetailDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceDetailDAL();
                }

                return instance;
            }

            set => instance = value;
        }

        private InvoiceDetailDAL() { }

        public static bool AddInvoiceDetail(Guid invoiceHeaderId, List<string> subClassIds)
        {
            bool isSuccess = false;

            try
            {
                using (var db = new UehDbContext())
                {
                    foreach (string subClass in subClassIds)
                    {
                        InvoiceDetail newInvoiceDetail = new InvoiceDetail()
                        {
                            InvoiceHeader_GuidInvoice = invoiceHeaderId,
                            SubjectClass_Id = subClass,
                        };

                        db.InvoiceDetails.Add(newInvoiceDetail);
                    }

                    db.SaveChanges();

                    isSuccess = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isSuccess;
        }

        public static List<string> GetPaidSubjectClasses(string studentId)
        {
            List<string> result;

            try
            {
                using (var db = new UehDbContext())
                {
                    result = (from stu in db.Students
                              where stu.StudentId == studentId
                              join invHea in db.InvoiceHeaders
                              on stu.StudentId equals invHea.Student_StudentId
                              join invDet in db.InvoiceDetails
                              on invHea.GuidInvoice equals invDet.InvoiceHeader_GuidInvoice
                              select invDet.SubjectClass_Id).ToList<string>();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static bool CheckExistencePaidSubject(string subject, int year, 
            int phase, string studentId)
        {
            bool isExist = false;

            try
            {
                using (var db = new UehDbContext())
                {
                    var data = (from stu in db.Students
                                where stu.StudentId == studentId
                                join invHea in db.InvoiceHeaders
                                on stu.StudentId equals invHea.Student_StudentId
                                join invDet in db.InvoiceDetails
                                on invHea.GuidInvoice equals invDet.InvoiceHeader_GuidInvoice
                                join subCla in db.SubjectClasses
                                on invDet.SubjectClass_Id equals subCla.Id
                                where subCla.Year == year && subCla.Semester == phase
                                join sub in db.Subjects
                                on subCla.Subject_Id equals sub.Id
                                where sub.Id == subject
                                select subCla).Count();

                    if (data > 0) return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isExist;
        }
    }
}
