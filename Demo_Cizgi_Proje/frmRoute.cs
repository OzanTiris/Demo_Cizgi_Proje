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
    public partial class frmRoute : Form
    {
        public frmRoute()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBookList frm =new frmBookList(); 
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMemberList frm = new frmMemberList();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmComment frm = new frmComment();
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kapatmak İstiyormusunuz?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayarlar Sayfası Pek Yakında Hazır Olacaktır...","Ayarlar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDeposit frm = new FrmDeposit();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAuthor frm = new frmAuthor();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmPublisher frm = new frmPublisher();
            frm.Show();
        }
    }
}
