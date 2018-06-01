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
    public partial class Insert_pv_form : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=(local);" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public Insert_pv_form()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insert_pv_form_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand fill = con.CreateCommand(); //создаём команду 
            fill.CommandText = "SELECT [Название] FROM [Город] ORDER BY [Код города] ";
            SqlDataReader reader2 = fill.ExecuteReader();//открыли ридер 
            while (reader2.Read())
            {
                cb_city.Items.Add(reader2["Название"].ToString());
            }
            reader2.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tb_mphone.Text[0] == '+') && (tb_mphone.Text[1] == '7') && (tb_mphone.Text.Length == 12))
                {
                    if (tb_phone.Text.Length == 5)
                    {
                        SqlCommand comm = con.CreateCommand(); //заполнение грида 
                        comm.CommandText = "Insert_pv";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.Add("@city", SqlDbType.VarChar);
                        comm.Parameters["@city"].Value = cb_city.Text.ToString();
                        comm.Parameters.Add("@x", SqlDbType.VarChar);
                        comm.Parameters["@x"].Value = tb_adr.Text.ToString();
                        comm.Parameters.Add("@y", SqlDbType.Int);
                        comm.Parameters["@y"].Value = int.Parse(tb_phone.Text.ToString());
                        comm.Parameters.Add("@z", SqlDbType.VarChar);
                        comm.Parameters["@z"].Value = tb_mphone.Text.ToString();
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Успешно добавлено", "Добавление",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неккоректное значение номера телефона", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неккоректное значение номера мобильного телефона", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(System.IndexOutOfRangeException)
            {
                MessageBox.Show("Поля не заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void tb_mphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }

        private void tb_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_pv_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
