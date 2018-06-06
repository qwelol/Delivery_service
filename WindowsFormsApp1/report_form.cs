using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class report_form : Form
    {
        public report_form()
        {
            InitializeComponent();
        }

        private void report_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Delivery_serviceDataSet.Отправление". При необходимости она может быть перемещена или удалена.
            this.ОтправлениеTableAdapter.Fill(this.Delivery_serviceDataSet.Отправление);

            this.reportViewer1.RefreshReport();
        }
    }
}
