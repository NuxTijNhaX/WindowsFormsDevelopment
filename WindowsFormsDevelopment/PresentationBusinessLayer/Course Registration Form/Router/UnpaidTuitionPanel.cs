using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    public partial class UnpaidTuitionPanel : Panel
    {
        public Panel pnlParent { get; set; }
        public dynamic studentInfor { get; set; }

        public UnpaidTuitionPanel(Panel pnl, object studentInfor)
        {
            pnlParent = pnl;
            this.studentInfor = studentInfor;

            this.Width = pnl.Width;
            this.Height = pnl.Height;
            this.BackColor = Color.White;

            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
