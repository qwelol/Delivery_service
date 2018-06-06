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
    public partial class insert_otpr_form : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=SYCH-PC;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public insert_otpr_form()
        {
            InitializeComponent();
        }

        private void insert_otpr_form_Load(object sender, EventArgs e)
        {
            con.Open();
            //заполениение типа доставки
            SqlCommand fill = con.CreateCommand(); //создаём команду 
            fill.CommandText = "SELECT [Тип доставки] FROM [Тип доставки] ORDER BY [Код доставки]";//заполнение 
            SqlDataReader reader = fill.ExecuteReader();//открыли ридер 
            while (reader.Read())
            {
                cb_type.Items.Add(reader["Тип доставки"].ToString());
            }
            reader.Close();

            // заполнение весовой категории
            fill.CommandText = "SELECT [Название] FROM [Весовая категория] ORDER BY [Код категории] ";
            //запрос можно запихнуть в ХП 
            SqlDataReader reader1 = fill.ExecuteReader();//открыли ридер 
            while (reader1.Read())
            {
                cb_veight.Items.Add(reader1["Название"].ToString());
            }
            reader1.Close();

            //заполение ВСЕХ полей с городами
            SqlCommand comm = con.CreateCommand();
            comm.CommandText = "show_city";
            comm.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader_city = comm.ExecuteReader();
            while (reader_city.Read())
            {
                cb_go.Items.Add(reader_city["Название"].ToString());
                cb_gp.Items.Add(reader_city["Название"].ToString());
            }
            reader_city.Close();

            cb_pp.Enabled = false;
            cb_po.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cb_go_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_po.Items.Clear();
            temp_otpr.Items.Clear();
            SqlCommand comm = con.CreateCommand(); 
            comm.CommandText = "Search_pv";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@x", SqlDbType.VarChar);
            comm.Parameters["@x"].Value = cb_go.Text.ToString();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                cb_po.Items.Add(reader["Адрес"].ToString());
                temp_otpr.Items.Add(reader["Код пункта"].ToString());
            }
            reader.Close();
        }

        private void cb_gp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_pp.Items.Clear();
            temp_pol.Items.Clear();
            SqlCommand comm = con.CreateCommand();
            comm.CommandText = "Search_pv";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@x", SqlDbType.VarChar);
            comm.Parameters["@x"].Value = cb_gp.Text.ToString();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                cb_pp.Items.Add(reader["Адрес"].ToString());
                temp_pol.Items.Add(reader["Код пункта"].ToString());
            }
            reader.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ins_btn_Click(object sender, EventArgs e)
        {if (tb_otpr.Text.ToString() != string.Empty && tb_pol.Text.ToString() != string.Empty)
            {
                if ((tb_otpr.Text[0] == '+') && (tb_otpr.Text[1] == '7') && (tb_otpr.Text.Length == 12)
                    && (tb_pol.Text[0] == '+') && (tb_pol.Text[1] == '7') && (tb_pol.Text.Length == 12)
                    )
                {
                    try
                    {
                        try
                        {
                            SqlCommand comm = con.CreateCommand(); //заполнение грида 
                            comm.CommandText = "insert_otpr";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Parameters.Add("@sender", SqlDbType.VarChar);
                            comm.Parameters["@sender"].Value = tb_otpr.Text.ToString();
                            comm.Parameters.Add("@receiver", SqlDbType.VarChar);
                            comm.Parameters["@receiver"].Value = tb_pol.Text.ToString();
                            comm.Parameters.Add("@td", SqlDbType.TinyInt);
                            comm.Parameters["@td"].Value = cb_type.SelectedIndex + 1;
                            comm.Parameters.Add("@vk", SqlDbType.TinyInt);
                            comm.Parameters["@vk"].Value = cb_veight.SelectedIndex + 1;
                            if (cb_po.Enabled == false)
                            {
                                SqlCommand comm1 = con.CreateCommand();
                                comm1.Parameters.Clear();
                                comm1.CommandText = "Show_main_pv";
                                comm1.CommandType = CommandType.StoredProcedure;
                                comm1.Parameters.Add("@city", SqlDbType.VarChar);
                                comm1.Parameters["@city"].Value = cb_go.Text;
                                SqlDataReader reader1 = comm1.ExecuteReader();
                                temp_otpr.Items.Clear();
                                while (reader1.Read())
                                {
                                    temp_otpr.Items.Add(reader1["Код пункта"].ToString());
                                }
                                reader1.Close();
                                if (temp_otpr.Items.Count != 0)
                                    temp_otpr.SelectedIndex = 0;
                                else return;
                            }
                            comm.Parameters.Add("@po", SqlDbType.Int);
                            comm.Parameters["@po"].Value = int.Parse(temp_otpr.Text.ToString());
                            if (cb_pp.Enabled == false)
                            {
                                SqlCommand comm1 = con.CreateCommand();
                                comm1.Parameters.Clear();
                                comm1.CommandText = "Show_main_pv";
                                comm1.CommandType = CommandType.StoredProcedure;
                                comm1.Parameters.Add("@city", SqlDbType.VarChar);
                                comm1.Parameters["@city"].Value = cb_gp.Text;
                                SqlDataReader reader1 = comm1.ExecuteReader();
                                temp_pol.Items.Clear();
                                while (reader1.Read())
                                {
                                    temp_pol.Items.Add(reader1["Код пункта"].ToString());
                                }
                                reader1.Close();
                                if (temp_pol.Items.Count != 0)
                                    temp_pol.SelectedIndex = 0;
                                else return;
                            }
                            comm.Parameters.Add("@pp", SqlDbType.Int);
                            comm.Parameters["@pp"].Value = int.Parse(temp_pol.Text.ToString());
                            comm.Parameters.Add("@comm", SqlDbType.VarChar);
                            comm.Parameters["@comm"].Value = tb_comm.Text.ToString();
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Успешно добавлено", "Добавление",
                            MessageBoxButtons.OK, MessageBoxIcon.None);
                            insert_content_form form = new insert_content_form();
                            form.Owner = this;
                            form.ShowDialog();
                            con.Close();
                            this.Close();
                        }
                        catch (System.FormatException)
                        {
                            MessageBox.Show("Такого клиента нет в базе", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                                            }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Совершать отправления может клиент, указавший свои паспортные данные", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неккоректное значение номера мобильного телефона", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_po_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp_otpr.SelectedIndex = cb_po.SelectedIndex;
        }

        private void cb_pp_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp_pol.SelectedIndex = cb_pp.SelectedIndex;
        }

        private void tb_otpr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }

        private void tb_pol_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pol_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }

        private void insert_otpr_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }


    }
}
