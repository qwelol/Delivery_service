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
    public partial class insert_content_form : Form
    {
        int a;
        static SqlConnection con = new SqlConnection("Data Source=SYCH-PC;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public insert_content_form()
        {
            InitializeComponent();
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            if (contentGrid.Rows.Count == 0)
            {
                MessageBox.Show("Должен быть хотя бы 1 пункт содержимого", "Удаление невозможно",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }

        }

        private void insert_content_form_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand fill = con.CreateCommand(); //создаём команду 
            fill.CommandText = "SELECT TOP 1 [Код посылки] FROM [Отправление] ORDER BY [Код посылки] DESC";//заполнение 
            SqlDataReader reader1 = fill.ExecuteReader();//открыли ридер 
            while (reader1.Read())
            {
                a = int.Parse(reader1["Код посылки"].ToString());
            }
            reader1.Close();
        }

        private void insert_content_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void tb_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tb_kol_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_kol_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tb_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void ins_btn_Click(object sender, EventArgs e)
        {
            //добавление
            try
            {
                SqlCommand comm1 = con.CreateCommand(); //заполнение грида 
                comm1.CommandText = "insert_content";
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("@code", SqlDbType.Int);
                comm1.Parameters["@code"].Value = a;
                comm1.Parameters.Add("@name", SqlDbType.VarChar);
                comm1.Parameters["@name"].Value = tb_name.Text.ToString();
                comm1.Parameters.Add("@price", SqlDbType.Real);
                comm1.Parameters["@price"].Value = Single.Parse(tb_value.Text.ToString());
                comm1.Parameters.Add("@amount", SqlDbType.Int);
                comm1.Parameters["@amount"].Value = int.Parse(tb_kol.Text.ToString());
                comm1.Parameters.Add("@weight", SqlDbType.Real);
                comm1.Parameters["@weight"].Value = Single.Parse(tb_weight.Text.ToString());
                comm1.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено", "Добавление",
                MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Не все поля заполнены", "Добавление невозможно",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // обновление содержимого
            refresh_content();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contentGrid.Rows.Count != 0)
            {
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "del_content";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@code", SqlDbType.Int);
                comm.Parameters["@code"].Value = a;
                comm.Parameters.Add("@name", SqlDbType.VarChar);
                comm.Parameters["@name"].Value = contentGrid[0, int.Parse(contentGrid.CurrentRow.Index.ToString())].Value.ToString();
                comm.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Удаление",
                MessageBoxButtons.OK, MessageBoxIcon.None);
                refresh_content();
            }
        }

        public void refresh_content()
        {
            contentGrid.Rows.Clear();
            tb_name.Clear();
            tb_value.Clear();
            tb_kol.Clear();
            tb_weight.Clear();
            SqlCommand comm = con.CreateCommand(); //заполнение грида 
            comm.CommandText = "search_content";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@code", SqlDbType.Int);
            comm.Parameters["@code"].Value = a;
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                contentGrid.Rows.Add(
                reader["Наименование товара"].ToString(),
                reader["Объявленная стоимость"].ToString(),
                reader["Количество"].ToString(),
                reader["Вес 1 шт."].ToString()
                );
            }
            reader.Close();
        }

    }
}
