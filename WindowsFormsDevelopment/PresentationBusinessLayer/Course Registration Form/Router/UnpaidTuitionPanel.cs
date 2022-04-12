using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDevelopment.CustomControls;
using WindowsFormsDevelopment.DataAccessLayer;
using WindowsFormsDevelopment.DataTransferObject;
using WindowsFormsDevelopment.PaymentGateway.MoMo;

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    public partial class UnpaidTuitionPanel : Panel
    {
        public Panel pnlParent { get; set; }
        public dynamic studentInfor { get; set; }
        private RoundedButton btnRender { get; set; }
        private int tuitionTotal;

        public UnpaidTuitionPanel(Panel pnl, object studentInfor, RoundedButton btnRender)
        {
            pnlParent = pnl;
            this.studentInfor = studentInfor;
            this.btnRender = btnRender;

            this.Width = pnl.Width;
            this.Height = pnl.Height;
            this.BackColor = Color.White;

            InitializeComponent();
            LoadTuitionTotal();
        }

        private void LoadTuitionTotal()
        {
            tuitionTotal = GradeSubjectClassDAL.GetTotalTuition(fCourseRegistration.studentId, fCourseRegistration.year,
                fCourseRegistration.phase, fCourseRegistration.fee);

            lblTuitionAmount.Text = "Không có khoản cần thanh toán";

            if (tuitionTotal != 0)
            {
                lblTuitionAmount.Text = tuitionTotal.ToString("c", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
        }

        private void ReRender()
        {
            btnRender.PerformClick();
        }

        private void SaveInvoice(Guid invoiceHeaderId, string description, 
            int payMedId, string studentId)
        {
            List<dynamic> subClasses = GradeSubjectClassDAL.GetRegisteredClasses(studentId,
                fCourseRegistration.year, fCourseRegistration.phase);

            List<string> subClassIds = new List<string>();

            foreach (dynamic subClass in subClasses)
            {
                subClassIds.Add(subClass.Id);
            }

            try
            {
                InvoiceHeaderDAL.AddInvoiceHeader(invoiceHeaderId, description, this.tuitionTotal, payMedId, studentId);
                InvoiceDetailDAL.AddInvoiceDetail(invoiceHeaderId, subClassIds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (tuitionTotal != 0)
            {
                Guid invoiceId = Guid.NewGuid();
                string orderDescription = studentInfor.Id + "-" + 
                    studentInfor.Name + "-Thanh toán học phí: " + description;
                int paymentMethodId;

                if (rbnMomo.Checked)
                {
                    try
                    {
                        paymentMethodId = PaymentMethodDAL.GetPaymentMethodId(rbnMomo.Text);

                        string response = new MoMo(tuitionTotal.ToString(),
                            orderDescription, invoiceId.ToString()).GetResponseFromMoMo();

                        JObject jsonResponse = JObject.Parse(response);

                        DialogResult result = MessageBox.Show("Bạn có chắc muốn mở trình duyệt để thanh toán?", "Thông Báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(jsonResponse.GetValue("payUrl").ToString());

                            ReRender();
                            SaveInvoice(invoiceId, orderDescription,
                                paymentMethodId, fCourseRegistration.studentId);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vui lòng kết nối internet để thanh toán", "Lỗi kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                if (rbnOcb.Checked)
                {
                    MessageBox.Show("Phương thức thanh toán đang được bảo trì.\nVui lòng chọn phương thức khác.",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rbnPaypal.Checked)
                {
                    MessageBox.Show("Phương thức thanh toán đang được bảo trì.\nVui lòng chọn phương thức khác.",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
