using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Cizgi_Proje
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            this.Text = count.ToString();
            if (count < 5)
            {
                lblHeader.BackColor = Color.White;
            }
            if (count > 5)
            {
                lblHeader.BackColor = Color.Red;
            }
            if (count == 10)
            {
                count = 0;
            }
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
