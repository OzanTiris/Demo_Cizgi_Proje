using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_Cizgi_Proje
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblAdmin where Username=@p1 and Password=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtusername.Text);
            command.Parameters.AddWithValue("@p2", txtpassword.Text);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hoşgeldiniz");

            }
            else
            {
                MessageBox.Show("Hata", "Proje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
