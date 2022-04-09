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
using WindowsFormsDevelopment.DataAccessLayer;
using WindowsFormsDevelopment.PaymentGateway.MoMo;

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    public partial class UnpaidTuitionPanel : Panel
    {
        public Panel pnlParent { get; set; }
        public dynamic studentInfor { get; set; }
        private int tuitionTotal;

        public UnpaidTuitionPanel(Panel pnl, object studentInfor)
        {
            pnlParent = pnl;
            this.studentInfor = studentInfor;

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

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (tuitionTotal != 0)
            {
                if(rbnMomo.Checked)
                {
                    string orderId = Guid.NewGuid().ToString();
                    string orderDescription = studentInfor.Id + "-" + studentInfor.Name + "-Thanh toán học phí: " + description;
                    string response = new MoMo(tuitionTotal.ToString(), 
                        orderDescription, orderId).GetResponseFromMoMo();

                    JObject jsonResponse = JObject.Parse(response);

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn mở trình duyệt để thanh toán?", "Thông Báo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(jsonResponse.GetValue("payUrl").ToString());
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
