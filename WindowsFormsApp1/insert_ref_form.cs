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

namespace WindowsFormsApp1
{
    public partial class insert_ref_form : Form
    {
        int code_p;
        static SqlConnection con = new SqlConnection("Data Source=SYCH-PC;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public insert_ref_form( int code)
        {
            InitializeComponent();
            code_p = code;
        }

        private void insert_ref_form_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void insert_ref_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = con.CreateCommand(); //заполнение грида 
            comm.CommandText = "insert_ref";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@code", SqlDbType.Int);
            comm.Parameters["@code"].Value = code_p;
            comm.Parameters.Add("@pr", SqlDbType.VarChar);
            comm.Parameters["@pr"].Value = tb_pr.Text.ToString();
            comm.Parameters.Add("@resh", SqlDbType.VarChar);
            comm.Parameters["@resh"].Value = tb_resh.Text.ToString();
            comm.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено", "Добавление",
            MessageBoxButtons.OK, MessageBoxIcon.None);
            Main_form main = this.Owner as Main_form;
            this.Close();
        }

        private void clc_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
