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
    public partial class PaymentHistoryPanel : Control
    {
        public Panel pnlParent { get; set; }

        public PaymentHistoryPanel(Panel pnl)
        {
            pnlParent = pnl;

            this.Width = pnl.Width;
            this.Height = pnl.Height;
            this.BackColor = Color.White;

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
