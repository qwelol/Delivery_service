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
    public partial class Insert_city_form : Form
    {
        static SqlConnection con = new SqlConnection("Data Source=ШАЛАШОВЫ-ПК" + "\\" + "SQLEXPRESS;" +
        "Initial Catalog=Delivery_service;" +
        "Integrated Security=true;");
        public Insert_city_form()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace 
            {
                e.Handled = true;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insert_city_form_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void Insert_city_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
