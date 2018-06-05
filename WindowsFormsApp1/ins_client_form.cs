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
    public partial class ins_client_form : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=SYCH-PC;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public ins_client_form()
        {
            InitializeComponent();
        }

        private void ins_client_form_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void cnl_btn_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void tb_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ins_btn_Click(object sender, EventArgs e)
        {
            if ((tb_pas.Text.ToString().Length == 10) || (tb_pas.Text.ToString() == string.Empty))
            {
                try
                {
                    SqlCommand comm = con.CreateCommand();
                    comm.CommandText = "insert_client";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("@phone", SqlDbType.VarChar);
                    if (tb_phone.Text.ToString() == string.Empty)
                        comm.Parameters["@phone"].Value = null;
                    else comm.Parameters["@phone"].Value = tb_phone.Text.ToString();
                    comm.Parameters.Add("@fam", SqlDbType.VarChar);
                    if (tb_fam.Text.ToString() == string.Empty)
                        comm.Parameters["@fam"].Value = null;
                    else comm.Parameters["@fam"].Value = tb_fam.Text.ToString();
                    comm.Parameters.Add("@name", SqlDbType.VarChar);
                    if (tb_name.Text.ToString() == string.Empty)
                        comm.Parameters["@name"].Value = null;
                    else comm.Parameters["@name"].Value = tb_name.Text.ToString();
                    comm.Parameters.Add("@pas", SqlDbType.BigInt);
                    if (tb_pas.Text.ToString() == string.Empty)
                    {
                        comm.Parameters["@pas"].Value = null;
                    }
                    else comm.Parameters["@pas"].Value = long.Parse(tb_pas.Text.ToString());
                    comm.Parameters.Add("@surname", SqlDbType.VarChar);
                    if (tb_surname.Text.ToString() == string.Empty)
                        comm.Parameters["@surname"].Value = null;
                    else comm.Parameters["@surname"].Value = tb_surname.Text.ToString();
                    comm.Parameters.Add("@adr", SqlDbType.VarChar);
                    if (tb_adr.Text.ToString() == string.Empty)
                        comm.Parameters["@adr"].Value = null;
                    else comm.Parameters["@adr"].Value = tb_adr.Text.ToString();
                    comm.Parameters.Add("@mail", SqlDbType.VarChar);
                    if (tb_mail.Text.ToString() == string.Empty)
                        comm.Parameters["@mail"].Value = null;
                    else comm.Parameters["@mail"].Value = tb_mail.Text.ToString();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Успешно изменено", "Изменение",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    Main_form main = this.Owner as Main_form;
                    if (main != null)
                    {
                        main.refresh_client();
                    }
                    this.Close();
                    con.Close();
            }
                catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Обязательные поля заполнены некоректно", "Изменение не сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            else
            {
                MessageBox.Show("Номер паспорта должен содержать 10 цифр", "Изменение не сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
