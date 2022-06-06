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
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");
        private void frmPublisher_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TblPublisher", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblPublisher (PublisherName,PublisherAdress,PublisherMail,PublisherPhone,PublisherDescription) values (@p1,@p2,@p3,@p4,@p5)", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtAddress.Text);
            command.Parameters.AddWithValue("@p3", txtMail.Text);
            command.Parameters.AddWithValue("@p4", txtPhone.Text);
            command.Parameters.AddWithValue("@p5", rchDescription.Text);
            

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("veri Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From Tblpublisher Where PublisherName=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblPublisher set PublisherName=@p1 ,PublisherAdress=@p2 ,PublisherMail=@p3,PublisherPhone=@p4,PublisherDescription=@p5 where PublisherName=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtAddress.Text);
            command.Parameters.AddWithValue("@p3", txtMail.Text);
            command.Parameters.AddWithValue("@p4", txtPhone.Text);
            command.Parameters.AddWithValue("@p5", rchDescription.Text);
            
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TblPublisher", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
    }
}
