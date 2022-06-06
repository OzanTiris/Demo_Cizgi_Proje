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
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }

        private void frmBookList_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");

            SqlCommand command = new SqlCommand("select * from TblBook", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
