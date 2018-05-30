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
    public partial class Change_mainpv_form : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=ШАЛАШОВЫ-ПК" + "\\" + "SQLEXPRESS;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public Change_mainpv_form()
        {
            InitializeComponent();
        }

        private void cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_new_main.Items.Clear();
            cb_main.Items.Clear();
            SqlCommand comm = con.CreateCommand(); //заполнение cb_cb_new_main 
            comm.CommandText = "Change_main_pv";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@city", SqlDbType.VarChar);
            comm.Parameters["@city"].Value = cb_city.Text;
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                cb_new_main.Items.Add(reader["Адрес"].ToString());
            }
            reader.Close();
            //заполнение cb_main 
            comm.Parameters.Clear();
            comm.CommandText = "Show_main_pv";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@city", SqlDbType.VarChar);
            comm.Parameters["@city"].Value = cb_city.Text;
            SqlDataReader reader1 = comm.ExecuteReader();
            while (reader1.Read())
            {
                cb_main.Items.Add(reader1["Адрес"].ToString());
            }
            reader1.Close();

            cb_main.SelectedIndex = 0;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_mainpv_form_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand fill = con.CreateCommand(); //создаём команду 
            fill.CommandText = "SELECT [Название] FROM [Город] ORDER BY [Код города] ";
            SqlDataReader reader = fill.ExecuteReader();//открыли ридер 
            while (reader.Read())
            {
                cb_city.Items.Add(reader["Название"].ToString());
            }
            reader.Close();

        }

        private void Change_mainpv_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (cb_city.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран город", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cb_new_main.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбран новый пункт выдачи", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand comm = con.CreateCommand(); //заполнение грида 
                    comm.CommandText = "Insert_Change_main_pv";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("@city", SqlDbType.VarChar);
                    comm.Parameters["@city"].Value = cb_city.Text;
                    comm.Parameters.Add("@p2", SqlDbType.VarChar);
                    comm.Parameters["@p2"].Value = cb_new_main.Text;
                    comm.ExecuteNonQuery();
                }
            }
        }
    }
}
