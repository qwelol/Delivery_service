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
            //заполениение типа доставки
            SqlCommand fill = con.CreateCommand(); //создаём команду 
            fill.CommandText = "SELECT [Тип доставки] FROM [Тип доставки] ORDER BY [Код доставки]";//заполнение 
            SqlDataReader reader = fill.ExecuteReader();//открыли ридер 
            while (reader.Read())
            {
                td_cb.Items.Add(reader["Тип доставки"].ToString());
            }
            reader.Close();

            //заполнение весовой категории
            fill.CommandText = "SELECT [Название] FROM [Весовая категория] ORDER BY [Код категории] ";
            //запрос можно запихнуть в ХП 
            SqlDataReader reader1 = fill.ExecuteReader();//открыли ридер 
            while (reader1.Read())
            {
                cb_vk.Items.Add(reader1["Название"].ToString());
            }
            reader1.Close();

            //заполение ВСЕХ полей с городами
            SqlCommand comm = con.CreateCommand();
            comm.CommandText = "show_city";
            comm.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader_city = comm.ExecuteReader();
            while (reader_city.Read())
            {
                city_grid.Rows.Add(
                reader_city["Название"].ToString(),
                reader_city["Область"].ToString(),
                reader_city["Телефонный код"].ToString()
                );
                cb_city.Items.Add(reader_city["Название"].ToString());
            }
            reader_city.Close();
        }

        private void Main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (cb_type.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            cb_po.Enabled = false;
            //            cb_pp.Enabled = false;
            //            break;
            //        }
            //    case 1:
            //        {
            //            cb_po.Enabled = true;
            //            cb_pp.Enabled = false;
            //            break;
            //        }
            //    case 2:
            //        {
            //            cb_po.Enabled = false;
            //            cb_pp.Enabled = true;
            //            break;
            //        }
            //    case 3:
            //        {
            //            cb_po.Enabled = true;
            //            cb_pp.Enabled = true;
            //            break;
            //        }
            //}
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
            try
            {
                string a = (pvGrid[3, int.Parse(pvGrid.CurrentRow.Index.ToString())].Value.ToString());
                string b = a.Substring(a.IndexOf('-') + 1);
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
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Некоректный номер телефона", "Изменение не сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
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
            try
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
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно удалить пункт выдачи с активными отправлениями", "Удаление невозможно",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adminPage_Click(object sender, EventArgs e)
        {

        }

        private void td_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand comm = con.CreateCommand();  
            comm.CommandText = "show_value";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@td", SqlDbType.VarChar);
            comm.Parameters["@td"].Value = td_cb.Text.ToString();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                tb_value.Text = reader["Цена"].ToString();
            }
            reader.Close();
        }

        private void tb_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ch_btn_Click(object sender, EventArgs e)
        {
            if (td_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран тип доставки", "Изменение не сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else
            {
                if (int.Parse(tb_value.Text.ToString()) != 0)
                {
                    try
                    {
                        SqlCommand comm = con.CreateCommand(); //заполнение грида 
                        comm.CommandText = "change_value";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.Add("@td", SqlDbType.VarChar);
                        comm.Parameters["@td"].Value = td_cb.Text.ToString();
                        comm.Parameters.Add("@value", SqlDbType.Real);
                        comm.Parameters["@value"].Value = Single.Parse(tb_value.Text.ToString());
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Успешно изменено", "Изменение",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Отсутствует значение", "Изменение не сохранено",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Стоимость дожна быть >0", "Изменение не сохранено",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void departurePage_Click(object sender, EventArgs e)
        {

        }

        protected void cb_vk_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm = con.CreateCommand();
                comm.CommandText = "show_VK_charge";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@vk", SqlDbType.VarChar);
                comm.Parameters["@vk"].Value = cb_vk.Text.ToString();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    tb_charhe.Text = reader["Наценка"].ToString();
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутствует значение", "Изменение не сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tb_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_charhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ch_vk_btn_Click(object sender, EventArgs e)
        {
            if (cb_vk.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран тип доставки", "Изменение не сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(tb_charhe.Text.ToString()) != 0)
                {
                    SqlCommand comm = con.CreateCommand();
                    comm.CommandText = "change_charge";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("@vk", SqlDbType.VarChar);
                    comm.Parameters["@vk"].Value = cb_vk.Text.ToString();
                    comm.Parameters.Add("@value", SqlDbType.Real);
                    comm.Parameters["@value"].Value = Single.Parse(tb_charhe.Text.ToString());
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Успешно изменено", "Изменение",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Наценка дожна быть >0", "Изменение не сохранено",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void del_vk_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "del_vk";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@vk", SqlDbType.VarChar);
                comm.Parameters["@vk"].Value = cb_vk.Text.ToString();
                comm.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Удаление",
                MessageBoxButtons.OK, MessageBoxIcon.None);

                cb_vk.Items.Clear();
                SqlCommand fill = con.CreateCommand();
                fill.CommandText = "SELECT [Название] FROM [Весовая категория] ORDER BY [Код категории] ";
                //запрос можно запихнуть в ХП 
                SqlDataReader reader1 = fill.ExecuteReader();//открыли ридер 
                while (reader1.Read())
                {
                    cb_vk.Items.Add(reader1["Название"].ToString());
                }
                reader1.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно удалить весовую категорию с активными отправлениями", "Удаление невозможно",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_charhe_TextChanged(object sender, EventArgs e)
        {

        }

        private void ins_vk_btn_Click(object sender, EventArgs e)
        {
            insert_vk_form form = new insert_vk_form();
            form.Owner = this;
            form.ShowDialog();
        }

        private void del_city_btn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = con.CreateCommand();
            try
            {
                comm.CommandText = "del_city";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@city", SqlDbType.VarChar);
                comm.Parameters["@city"].Value = city_grid[0, int.Parse(city_grid.CurrentRow.Index.ToString())].Value.ToString();
                comm.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Удаление",
                MessageBoxButtons.OK, MessageBoxIcon.None);
                refresh_city();

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно удалить город, в котором имеются пункты выдачи", "Удаление невозможно",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ins_city_btn_Click(object sender, EventArgs e)
        {
            insert_city_form form = new insert_city_form();
            form.Owner = this;
            form.ShowDialog();
        }

        public void refresh_client()
        {
            if (rb_fam.Checked == true)
            {
                client_grid.Rows.Clear();
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "Search_client_fam";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@fam", SqlDbType.VarChar);
                comm.Parameters["@fam"].Value = tb_fam.Text.ToString();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    client_grid.Rows.Add(
                    reader["Номер телефона"].ToString(),
                    reader["Номер паспорта"].ToString(),
                    reader["Фамилия"].ToString(),
                    reader["Имя"].ToString(),
                    reader["Отчество"].ToString(),
                    reader["Электронная почта"].ToString(),
                    reader["Адрес"].ToString()
                    );
                }
                reader.Close();
            }
            else
            {
                client_grid.Rows.Clear();
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "Search_client_phone";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@phone", SqlDbType.VarChar);
                comm.Parameters["@phone"].Value = tb_phone.Text.ToString();
                SqlDataReader reader1 = comm.ExecuteReader();
                while (reader1.Read())
                {
                    client_grid.Rows.Add(
                    reader1["Номер телефона"].ToString(),
                    reader1["Номер паспорта"].ToString(),
                    reader1["Фамилия"].ToString(),
                    reader1["Имя"].ToString(),
                    reader1["Отчество"].ToString(),
                    reader1["Электронная почта"].ToString(),
                    reader1["Адрес"].ToString()
                    );
                }
                reader1.Close();
            }
        }

        public void refresh_city ()
        {
            SqlCommand comm = con.CreateCommand();
            comm.Parameters.Clear();
            cb_city.Items.Clear();
            city_grid.Rows.Clear();

            comm.CommandText = "show_city";
            comm.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader_city = comm.ExecuteReader();
            while (reader_city.Read())
            {
                city_grid.Rows.Add(
                reader_city["Название"].ToString(),
                reader_city["Область"].ToString(),
                reader_city["Телефонный код"].ToString()
                );
                cb_city.Items.Add(reader_city["Название"].ToString());
            }
            reader_city.Close();
        }

        private void searh_btn_Click(object sender, EventArgs e)
        {
            refresh_client();
            //if (rb_fam.Checked == true)
            //{
            //    client_grid.Rows.Clear();
            //    SqlCommand comm = con.CreateCommand(); //заполнение грида 
            //    comm.CommandText = "Search_client_fam";
            //    comm.CommandType = CommandType.StoredProcedure;
            //    comm.Parameters.Add("@fam", SqlDbType.VarChar);
            //    comm.Parameters["@fam"].Value = tb_fam.Text.ToString();
            //    SqlDataReader reader = comm.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        client_grid.Rows.Add(
            //        reader["Номер телефона"].ToString(),
            //        reader["Номер паспорта"].ToString(),
            //        reader["Фамилия"].ToString(),
            //        reader["Имя"].ToString(),
            //        reader["Отчество"].ToString(),
            //        reader["Электронная почта"].ToString(),
            //        reader["Адрес"].ToString()
            //        );
            //    }
            //    reader.Close();
            //}
            //else
            //{
            //            client_grid.Rows.Clear();
            //            SqlCommand comm = con.CreateCommand(); //заполнение грида 
            //            comm.CommandText = "Search_client_phone";
            //            comm.CommandType = CommandType.StoredProcedure;
            //            comm.Parameters.Add("@phone", SqlDbType.VarChar);
            //            comm.Parameters["@phone"].Value = tb_phone.Text.ToString();
            //            SqlDataReader reader1 = comm.ExecuteReader();
            //            while (reader1.Read())
            //            {
            //                client_grid.Rows.Add(
            //                reader1["Номер телефона"].ToString(),
            //                reader1["Номер паспорта"].ToString(),
            //                reader1["Фамилия"].ToString(),
            //                reader1["Имя"].ToString(),
            //                reader1["Отчество"].ToString(),
            //                reader1["Электронная почта"].ToString(),
            //                reader1["Адрес"].ToString()
            //                );
            //            }
            //            reader1.Close();
            //}
        }

        private void del_client_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "del_client";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@phone", SqlDbType.VarChar);
                comm.Parameters["@phone"].Value = client_grid[0, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
                comm.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Удаление",
                MessageBoxButtons.OK, MessageBoxIcon.None);
                refresh_client();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно удалить клиента, имеющего активные отправления", "Удаление невозможно",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void ins_client_btn_Click(object sender, EventArgs e)
        {
            ins_client_form form = new ins_client_form();
            form.Owner = this;
            form.ShowDialog();
        }

        private void tb_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }

        private void cng_client_btn_Click(object sender, EventArgs e)
        {
            if ((tb_ch_pas.Text.ToString().Length == 10) || (tb_ch_pas.Text.ToString() == string.Empty))
            {
                try
                {
                    SqlCommand comm = con.CreateCommand();
                    comm.CommandText = "change_client";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("@newphone", SqlDbType.VarChar);
                    if (tb_ch_phone.Text.ToString() == string.Empty)
                        comm.Parameters["@newphone"].Value = null;
                    else comm.Parameters["@newphone"].Value = tb_ch_phone.Text.ToString();
                    comm.Parameters.Add("@oldphone", SqlDbType.VarChar);
                    comm.Parameters["@oldphone"].Value = client_grid[0, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
                    comm.Parameters.Add("@fam", SqlDbType.VarChar);
                    if (tb_ch_fam.Text.ToString() == string.Empty)
                        comm.Parameters["@fam"].Value = null;
                    else comm.Parameters["@fam"].Value = tb_ch_fam.Text.ToString();
                    comm.Parameters.Add("@name", SqlDbType.VarChar);
                    if (tb_ch_name.Text.ToString() == string.Empty)
                        comm.Parameters["@name"].Value = null;
                    else comm.Parameters["@name"].Value = tb_ch_name.Text.ToString();
                    comm.Parameters.Add("@pas", SqlDbType.BigInt);
                    if (tb_ch_pas.Text.ToString() == string.Empty)
                    {
                        comm.Parameters["@pas"].Value = null;
                    }
                    else comm.Parameters["@pas"].Value = long.Parse(tb_ch_pas.Text.ToString());
                    comm.Parameters.Add("@surname", SqlDbType.VarChar);
                    if (tb_ch_sur.Text.ToString() == string.Empty)
                        comm.Parameters["@surname"].Value = null;
                    else comm.Parameters["@surname"].Value = tb_ch_sur.Text.ToString();
                    comm.Parameters.Add("@adr", SqlDbType.VarChar);
                    if (tb_ch_adr.Text.ToString() == string.Empty)
                        comm.Parameters["@adr"].Value = null;
                    else comm.Parameters["@adr"].Value = tb_ch_adr.Text.ToString();
                    comm.Parameters.Add("@mail", SqlDbType.VarChar);
                    if (tb_ch_mail.Text.ToString() == string.Empty)
                        comm.Parameters["@mail"].Value = null;
                    else comm.Parameters["@mail"].Value = tb_ch_mail.Text.ToString();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Успешно изменено", "Изменение",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    refresh_client();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Обязательные поля заполнены некоректно", "Изменение не сохранено",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Некоректный номер паспорта", "Изменение не сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_ch_pas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void client_grid_SelectionChanged(object sender, EventArgs e)
        {
            tb_ch_phone.Text = client_grid[0, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
            tb_ch_pas.Text = client_grid[1, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
            tb_ch_mail.Text = client_grid[5, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
            tb_ch_fam.Text = client_grid[2, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
            tb_ch_name.Text = client_grid[3, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
            tb_ch_sur.Text = client_grid[4, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString();
            tb_ch_adr.Text = client_grid[6, int.Parse(client_grid.CurrentRow.Index.ToString())].Value.ToString(); 
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            refresh_dep();
            refresh_content();
            refresh_ref();
        }

        public void refresh_dep()
        {
            if (tb_code.Text.ToString() != String.Empty)
            {
                departureGrid.Rows.Clear();
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "search_otp_code";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@code", SqlDbType.Int);
                comm.Parameters["@code"].Value = tb_code.Text.ToString();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    departureGrid.Rows.Add(
                    reader["Код посылки"].ToString(),
                    reader["Отправитель"].ToString(),
                    reader["Получатель"].ToString(),
                    reader["Тип доставки"].ToString(),
                    reader["Весовая категория"].ToString(),
                    reader["Пункт отправления"].ToString(),
                    reader["Пункт получения"].ToString(),
                    reader["Дата отправления"].ToString(),
                    reader["Стоимость"].ToString(),
                    reader["Статус"].ToString(),
                    reader["Дата получения"].ToString(),
                    reader["Комментарий"].ToString()
                    );
                }
                reader.Close();
            }
            else
            { departureGrid.Rows.Clear(); }
        }

        public void refresh_ref()
        {
            refGrid.Rows.Clear();
            SqlCommand comm = con.CreateCommand(); //заполнение грида 
            comm.CommandText = "search_ref";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@code", SqlDbType.Int);
            try
            {
                comm.Parameters["@code"].Value = int.Parse(departureGrid[0, int.Parse(departureGrid.CurrentRow.Index.ToString())].Value.ToString());
            }
            catch (System.NullReferenceException)
            { comm.Parameters["@code"].Value = 0; }
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                refGrid.Rows.Add(
                reader["Дата отказа"].ToString(),
                reader["Причина"].ToString(),
                reader["Решение"].ToString()
                );
            }
            reader.Close();
        }

        public void refresh_content()
        {
            contentGrid.Rows.Clear();
            SqlCommand comm = con.CreateCommand(); //заполнение грида 
            comm.CommandText = "search_content";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@code", SqlDbType.Int);
            try
            {
                comm.Parameters["@code"].Value = int.Parse(departureGrid[0, int.Parse(departureGrid.CurrentRow.Index.ToString())].Value.ToString());
            }
            catch (System.NullReferenceException)
            { comm.Parameters["@code"].Value = 0; }
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

        private void tb_fam_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }

        private void tb_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            refresh_ref();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm = con.CreateCommand(); //заполнение грида 
                comm.CommandText = "del_otpr";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@code", SqlDbType.Int);
                try
                {
                    comm.Parameters["@code"].Value = int.Parse(departureGrid[0, int.Parse(departureGrid.CurrentRow.Index.ToString())].Value.ToString());
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Успешно удалено", "Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    refresh_dep();
                }
                catch (System.NullReferenceException)
                { comm.Parameters["@code"].Value = 0; }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно удалить активное отправление", "Удаление невозможно",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            insert_otpr_form form = new insert_otpr_form();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
