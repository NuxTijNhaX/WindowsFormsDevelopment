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

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    public partial class PaymentHistoryPanel : Panel
    {
        public Panel pnlParent { get; set; }

        public PaymentHistoryPanel(Panel pnl)
        {
            pnlParent = pnl;

            this.Width = pnl.Width;
            this.Height = pnl.Height;
            this.BackColor = Color.White;

            InitializeComponent();

            LoadPaymentHistory();
        }

        private void LoadPaymentHistory()
        {
            List<object> paidSubClasses = InvoiceHeaderDAL.GetInvoiceHeaders(fCourseRegistration.studentId);

            foreach (dynamic paidSubClass in paidSubClasses)
            {
                var row = new DataGridViewRow();
                var cellInvoice = new DataGridViewTextBoxCell()
                {
                    Value = paidSubClass.Id.ToString(),
                };
                var cellDes = new DataGridViewTextBoxCell()
                {
                    Value = paidSubClass.Des,
                };
                var cellPaidDate = new DataGridViewTextBoxCell()
                {
                    Value = paidSubClass.Date.ToString("dd/MM/yyyy"),
                };
                var cellAmount = new DataGridViewTextBoxCell()
                {
                    Value = paidSubClass.Total.ToString("c", CultureInfo.CreateSpecificCulture("vi-VN")),
                };
                var cellMethod = new DataGridViewTextBoxCell()
                {
                    Value = paidSubClass.Payment,
                };

                row.Cells.AddRange(new DataGridViewCell[]
                {
                    cellInvoice,
                    cellDes,
                    cellPaidDate,
                    cellMethod,
                    cellAmount,
                });

                dgvPaymentHistory.Rows.Add(row);
            }
        }

        private void dgvCourseTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvPaymentHistory.Rows[e.RowIndex].Height = 40;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
