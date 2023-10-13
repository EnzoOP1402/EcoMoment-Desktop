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
    public partial class FormExcluirAtualizarUsuarioWeb : Form
    {

        int op = 0;

        public FormExcluirAtualizarUsuarioWeb(int p)
        {
            InitializeComponent();
            if(p == 1)
            {
                btnExcluirWeb.Text = "Atualizar";
                op=1;
            }
            else
            {
                btnExcluirWeb.Text = "Excluir";
                op=2;
            }
        }

        private void gpbxExcluirWeb_Enter(object sender, EventArgs e)
        {

        }
    }
}
