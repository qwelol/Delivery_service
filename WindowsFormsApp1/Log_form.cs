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
    public partial class Log_form : Form
    {
        public Log_form()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string pas = pass_box.Text;
            bool user;
            if ((comboBox1.SelectedIndex == 0) && (pas=="111"))
            {
                this.Hide();
                user = false;
                Main_form form = new Main_form(user);
                form.Owner = this;
                form.ShowDialog();
            }
            else
            {
                if ((comboBox1.SelectedIndex == 1) && (pas == "admin"))
                {
                    this.Hide();
                    user = true;
                    Main_form form = new Main_form(user);
                    form.Owner = this;
                    form.ShowDialog();
                 }
                else
                {
                    MessageBox.Show("Неверный пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
