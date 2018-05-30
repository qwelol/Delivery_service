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
    }
}
