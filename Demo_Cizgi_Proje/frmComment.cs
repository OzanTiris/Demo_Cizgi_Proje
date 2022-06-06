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
    public partial class frmComment : Form
    {
        public frmComment()
        {
            InitializeComponent();
        }

        private void frmComment_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");


            //yorum 1
            connection.Open();
            SqlCommand command1 = new SqlCommand("select top 3 * from TblComment order by CommentID Desc ", connection);
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                lblCommentUserName1.Text= dr  ["CommentUser"].ToString();
                lblCommentDetails1.Text= dr ["CommentContent"].ToString();
                
            }
            connection.Close();



            //yorum 2

            connection.Open();
            SqlCommand command2 = new SqlCommand("select top 2 * from TblComment order by CommentID Desc", connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                lblCommentUserName2.Text= dr2["CommentUser"].ToString();
                lblCommentDetails2.Text= dr2["CommentContent"].ToString();
            }
            connection.Close();

            //yorum 3


            connection.Open();
            SqlCommand command3 = new SqlCommand("select top 1 * from TblComment order by CommentID Desc ", connection);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                
                lblCommentUserName3.Text= dr3["CommentUser"].ToString();
                lblCommentDetails3.Text= dr3["CommentContent"].ToString();
            }
            connection.Close();
        }
    }
}
