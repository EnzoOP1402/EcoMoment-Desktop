using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoMoment_Desktop
{
    public partial class FormConsultaAdm : Form
    {
        public FormConsultaAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsultaIdAdm f1 = new FormConsultaIdAdm();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormConsultaTodosAdm f1 = new FormConsultaTodosAdm();
            f1.Show();
        }
    }
}
