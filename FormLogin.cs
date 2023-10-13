using Projeto_DuplinhaFeroz;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro fc = new FormCadastro();
            fc.MdiParent = this;
            fc.Show();
            panel1.Visible = false;
        }

        private void usuárioAdmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(DAO_Conexao.VeriLogin(txtEmailEntrar.Text, txtSenhaEntrar.Text)==1)
            {
                MessageBox.Show("Login realizado com sucesso!");
                menuToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum usuário cadastrado com esse email. Tente novamente com um email e/ou senha diferente ou se cadastre agora mesmo");
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb f1 = new FormExcluirAtualizarUsuarioWeb(2);
            f1.MdiParent = this;
            f1.Show();
            panel1.Visible = false;
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb f1 = new FormExcluirAtualizarUsuarioWeb(1);
            f1.MdiParent = this;
            f1.Show();
            panel1.Visible = false;
        }
    }
}
