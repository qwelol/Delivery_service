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
    public partial class insert_city_form : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=(local);" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public insert_city_form()
        {
            InitializeComponent();
        }

        private void cnl_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

        private void insert_city_form_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void tb_code_KeyPress(object sender, KeyPressEventArgs e)
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
                try
                {
                    SqlCommand comm = con.CreateCommand(); //заполнение грида 
                    comm.CommandText = "ins_city";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("@city", SqlDbType.VarChar);
                    comm.Parameters["@city"].Value = tb_name.Text.ToString();
                    comm.Parameters.Add("@area", SqlDbType.VarChar);
                    comm.Parameters["@area"].Value = tb_obl.Text.ToString();
                    comm.Parameters.Add("@phone_code", SqlDbType.Int);
                    comm.Parameters["@phone_code"].Value = int.Parse(tb_code.Text.ToString());
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Успешно добавлено", "Добавление",
                    MessageBoxButtons.OK, MessageBoxIcon.None);

                    Main_form main = this.Owner as Main_form;
                    if (main != null)
                    {
                        main.refresh_city();
                    }
                    this.Close();
                    con.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Город с таким телефонным кодом уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }
            catch (System.FormatException)
            {
                MessageBox.Show("Поля не заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
