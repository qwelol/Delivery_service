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
    public partial class insert_vk_form : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=SYCH-PC;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public insert_vk_form()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "ins_vk";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@vk", SqlDbType.VarChar);
                comm.Parameters["@vk"].Value = tb_name.Text.ToString();
                comm.Parameters.Add("@charge", SqlDbType.Int);
                comm.Parameters["@charge"].Value = int.Parse(tb_charge.Text.ToString());
                comm.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено", "Добавление",
                MessageBoxButtons.OK, MessageBoxIcon.None);
                Main_form main = this.Owner as Main_form;
                if (main != null)
                {
                    main.cb_vk.Items.Clear();
                    SqlCommand fill = con.CreateCommand();
                    fill.CommandText = "SELECT [Название] FROM [Весовая категория] ORDER BY [Код категории] ";
                    //запрос можно запихнуть в ХП 
                    SqlDataReader reader1 = fill.ExecuteReader();//открыли ридер 
                    while (reader1.Read())
                    {
                        main.cb_vk.Items.Add(reader1["Название"].ToString());
                    }
                    reader1.Close();
                    this.Close();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Поля не заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insert_vk_form_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void insert_vk_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void cncl_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
