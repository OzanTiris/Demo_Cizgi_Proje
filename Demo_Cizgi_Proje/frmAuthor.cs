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
    public partial class frmAuthor : Form
    {
        public frmAuthor() //yazar table ını çağırmak için
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");
        private void BtnList_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand ("select * from TblAuthor",connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e) //yazarları kaydetmek için
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblAuthor (AuthorName,AuthorSurname,BirthPlace,AuthorAbout) values (@p1,@p2,@p3,@p4)",connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);          
            command.Parameters.AddWithValue("@p3", txtBirthPlace.Text);
            command.Parameters.AddWithValue("@p4", rchDescription.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yazar Eklendi");


        }

        private void BtnDelete_Click(object sender, EventArgs e)  //yazar silmek için
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblAuthor Where AuthorID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtıd.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");

            connection.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e) //yazar güncellemek için
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblAuthor set AuthorName=@p1 ,AuthorSurname=@p2 ,BirthPlace=@p4,AuthorAbout=@p5 where AuthorID=@p3", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", txtıd.Text);
            command.Parameters.AddWithValue("@p4", txtBirthPlace.Text);
            command.Parameters.AddWithValue("@p5", rchDescription.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            connection.Close();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True