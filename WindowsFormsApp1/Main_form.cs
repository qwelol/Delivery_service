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
    public partial class Main_form : Form
    {

        bool user_type;
        static SqlConnection con = new SqlConnection("Data Source=SYCH-PC;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public Main_form(bool user)
        {
            InitializeComponent();
            user_type = user;
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            con.Open();
            if (user_type==false)
            {
                adminPage.Parent = null;

            }
            SqlCommand fill = con.CreateCommand(); //создаём команду 
            fill.CommandText = "SELECT [Тип доставки] FROM [Тип доставки] ORDER BY [Код доставки]";//заполнение 
            SqlDataReader reader = fill.ExecuteReader();//открыли ридер 
            while (reader.Read())
            {
                cb_type.Items.Add(reader["Тип доставки"].ToString());
            }
            reader.Close();

            fill.CommandText = "SELECT [Название] FROM [Весовая категория] ORDER BY [Код категории] ";
            //запрос можно запихнуть в ХП 
            SqlDataReader reader1 = fill.ExecuteReader();//открыли ридер 
            while (reader1.Read())
            {
                cb_veight.Items.Add(reader1["Название"].ToString());
            }
            reader1.Close();

            fill.CommandText = "SELECT [Название] FROM [Город] ORDER BY [Код города] ";
            //запрос можно запихнуть в ХП 
            SqlDataReader reader2 = fill.ExecuteReader();//открыли ридер 
            while (reader2.Read())
            {
                cb_city.Items.Add(reader2["Название"].ToString());
            }
            reader2.Close();

            cb_po.Enabled = false;
            cb_pp.Enabled = false;
            refGrid.Enabled = false;
        }

        private void Main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_type.SelectedIndex)
            {
                case 0:
                    {
                        cb_po.Enabled = false;
                        cb_pp.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        cb_po.Enabled = true;
                        cb_pp.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        cb_po.Enabled = false;
                        cb_pp.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        cb_po.Enabled = true;
                        cb_pp.Enabled = true;
                        break;
                    }
            }
        }

        private void comment_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.SelectedIndex == 2)
            {
                refGrid.Enabled = true;
            }
            else
            {
                refGrid.Enabled = false;
            }

        }

        private void cb_veight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tb_mphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pv_search_btn_Click(object sender, EventArgs e)
        {
            if (cb_city.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран город", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                pvGrid.Rows.Clear();
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "Search_pv";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@x", SqlDbType.VarChar);
                comm.Parameters["@x"].Value = cb_city.Text.ToString();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    pvGrid.Rows.Add(
                    reader["Код пункта"].ToString(),
                    reader["Город"].ToString(),
                    reader["Адрес"].ToString(),
                    reader["Городской телефон"].ToString(),
                    reader["Мобильный телефон"].ToString()
                    );
                }
                reader.Close();
        }

        private void pvGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pvGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pvGrid_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            string a = (pvGrid[3, int.Parse(pvGrid.CurrentRow.Index.ToString())].Value.ToString());
            string b=a.Substring(a.IndexOf('-') + 1);
            SqlCommand comm = con.CreateCommand(); //заполнение грида 
            comm.CommandText = "Update_pv";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@a", SqlDbType.Int);
            comm.Parameters["@a"].Value = int.Parse(pvGrid[0, int.Parse(pvGrid.CurrentRow.Index.ToString())].Value.ToString());
            comm.Parameters.Add("@x", SqlDbType.VarChar);
            comm.Parameters["@x"].Value = pvGrid[2, int.Parse(pvGrid.CurrentRow.Index.ToString())].Value.ToString();
            comm.Parameters.Add("@y", SqlDbType.Int);
            comm.Parameters["@y"].Value = int.Parse(b);
            comm.Parameters.Add("@z", SqlDbType.VarChar);
            comm.Parameters["@z"].Value = pvGrid[4, int.Parse(pvGrid.CurrentRow.Index.ToString())].Value.ToString();
            comm.ExecuteNonQuery();
        }

        private void save_pv_btn_Click(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            Insert_pv_form form = new Insert_pv_form();
            form.Owner = this;
            form.ShowDialog();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = con.CreateCommand(); //заполнение грида 
            comm.CommandText = "Delete_pv";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@pynkt", SqlDbType.Int);
            comm.Parameters["@pynkt"].Value = int.Parse(pvGrid[0, int.Parse(pvGrid.CurrentRow.Index.ToString())].Value.ToString());
            comm.ExecuteNonQuery();
            MessageBox.Show("Успешно удалено", "Удаление",
            MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void change_pv_btn_Click(object sender, EventArgs e)
        {
            Change_mainpv_form form = new Change_mainpv_form();
            form.Owner = this;
            form.ShowDialog();
        }

        private void cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
