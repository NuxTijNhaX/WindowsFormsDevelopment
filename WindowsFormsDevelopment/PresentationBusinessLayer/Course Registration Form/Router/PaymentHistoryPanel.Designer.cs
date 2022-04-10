
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    partial class PaymentHistoryPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            dgvPaymentHistory = new DataGridView();
            colInvoiceNumber = new DataGridViewTextBoxColumn();
            colContent = new DataGridViewTextBoxColumn();
            colPaidDate = new DataGridViewTextBoxColumn();
            colMethod = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();

            this.Controls.AddRange(new Control[]
            {
                dgvPaymentHistory,
            });

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            headerStyle.Font = fCourseRegistration.font10;
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rowStyle.BackColor = Color.White;
            rowStyle.Font = fCourseRegistration.font10_Regular;
            rowStyle.ForeColor = Color.Black;
            rowStyle.SelectionBackColor = fCourseRegistration.green;
            rowStyle.SelectionForeColor = SystemColors.HighlightText;
            rowStyle.WrapMode = DataGridViewTriState.True;

            dgvPaymentHistory.Size = new Size(this.Width, this.Height);
            dgvPaymentHistory.RowHeadersVisible = false;
            dgvPaymentHistory.AllowUserToAddRows = false;
            dgvPaymentHistory.AllowUserToDeleteRows = false;
            dgvPaymentHistory.BackgroundColor = Color.White;
            dgvPaymentHistory.BorderStyle = BorderStyle.None;
            dgvPaymentHistory.ColumnHeadersHeight = 45;
            dgvPaymentHistory.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvPaymentHistory.RowsDefaultCellStyle = rowStyle;
            dgvPaymentHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentHistory.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCourseTable_RowsAdded);

            dgvPaymentHistory.Columns.AddRange(new DataGridViewColumn[] {
                colInvoiceNumber,
                colContent,
                colPaidDate,
                colMethod,
                colAmount,
            });

            colInvoiceNumber.HeaderText = "Số hóa đơn";
            colInvoiceNumber.Name = "colInvoiceNumber";
            colInvoiceNumber.ReadOnly = true;
            colInvoiceNumber.Width = dgvPaymentHistory.Width * 17 / 100;

            colContent.HeaderText = "Nội dung thu";
            colContent.Name = "colContent";
            colContent.ReadOnly = true;
            colContent.Width = dgvPaymentHistory.Width * 30 / 100;

            colPaidDate.HeaderText = "Ngày đóng";
            colPaidDate.Name = "colPaidDate";
            colPaidDate.ReadOnly = true;
            colPaidDate.Width = dgvPaymentHistory.Width * 17 / 100;

            colMethod.HeaderText = "Hình thức nộp";
            colMethod.Name = "colMethod";
            colMethod.ReadOnly = true;
            colMethod.Width = dgvPaymentHistory.Width * 16 / 100;

            colAmount.HeaderText = "Thành tiền";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = dgvPaymentHistory.Width * 20 / 100;
        }

        #endregion

        private DataGridView dgvPaymentHistory;
        private DataGridViewTextBoxColumn colInvoiceNumber;
        private DataGridViewTextBoxColumn colContent;
        private DataGridViewTextBoxColumn colPaidDate;
        private DataGridViewTextBoxColumn colMethod;
        private DataGridViewTextBoxColumn colAmount;
    }
}
