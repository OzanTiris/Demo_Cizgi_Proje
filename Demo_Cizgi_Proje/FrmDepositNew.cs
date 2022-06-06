using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Cizgi_Proje
{
    public partial class FrmDepositNew : Form
    {
        public FrmDepositNew()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");
        private void btnAktifEmanet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select DepositID,BookName,MemberName + ' ' + MemberSurname,DepositBorrowDate,DepositReturnDate, DepositPunishAmount, DepositStatus from TblDeposit   inner join TblBook  on TblDeposit.BookID = TblBook.BookID inner join TblMember  on TblDeposit.MemberID = TblMember.MemberID where DepositStatus=1" , connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select DepositID,BookName,MemberName + ' ' + MemberSurname,DepositBorrowDate,DepositReturnDate, DepositPunishAmount, DepositStatus from TblDeposit   inner join TblBook  on TblDeposit.BookID = TblBook.BookID inner join TblMember  on TblDeposit.MemberID = TblMember.MemberID where DepositStatus=0", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEmanetVer_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tbldeposit (BookId,MemberID,DepositBorrowDate,DepositReturnDate,DepositPunishAmount,DepositStatus) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", txtBook.Text);
            command.Parameters.AddWithValue("@p2", txtMember.Text);
            command.Parameters.AddWithValue("@p3", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@p4", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@p5",0);
            command.Parameters.AddWithValue("@p6",true);
            command.ExecuteNonQuery();
            MessageBox.Show("Kitap Teslim Edildi");


            connection.Close();
        }

        private void btnEmanetAl_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tbldeposit set depositStatus=0 where DepositId=@p1",connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("kayıt başarılı şekilde güncellendi");
            connection.Close();
        }
    }
}
