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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");
            ////chart1
            //chart1.Series["Series1"].Points.AddXY("Roman", 35);
            //chart1.Series["Series1"].Points.AddXY("Hikaye", 22);
            //chart1.Series["Series1"].Points.AddXY("Tiyatro", 16);
            //chart1.Series["Series1"].Points.AddXY("Şiir", 18);


            //chart2
            chart2.Series["Series1"].Points.AddXY("Yerli Kitap", 125);
            chart2.Series["Series1"].Points.AddXY("Yabancı Kitap", 87);

            //İstatistik 1

            connection.Open();

            SqlCommand command = new SqlCommand("select count(*) from TblMember", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[0].ToString();
            }
            connection.Close();



            //İstatistik 2

            connection.Open();

            SqlCommand command2 = new SqlCommand("select count(*) from TblBook", connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                label7.Text = dr2[0].ToString();
            }
            connection.Close();




            //İstatistik 3

            connection.Open();

            SqlCommand command3 = new SqlCommand("select count(*) from TblAuthor", connection);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                label5.Text = dr3[0].ToString();
            }
            connection.Close();



            //haftanın kitabı

            connection.Open();

            SqlCommand command4 = new SqlCommand("select BookName from TblBook where BookID=10", connection);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                label2.Text = dr4[0].ToString();
            }
            connection.Close();


            //İstatistik grafik chart

            connection.Open();

            SqlCommand command5 = new SqlCommand("select Category ,count(*) from TblBook Group by Category", connection);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                chart1.Series["Series1"].Points.AddXY(dr5[0], dr5[1]);
            }
            connection.Close();



        }
    }
}
