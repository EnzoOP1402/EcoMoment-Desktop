using Projeto_DuplinhaFeroz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoMoment_Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();


            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("\nConectado\n");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void splashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro fc = new FormCadastro();
            fc.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(DAO_Conexao.VeriLogin(txtEmailEntrar.Text, txtSenhaEntrar.Text)==1)
            {
                MessageBox.Show("Login realizado com sucesso!");
                menuToolStripMenuItem.Enabled = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Nenhum usuário cadastrado com esse email. Tente novamente com um email e/ou senha diferente ou cadastre-se agora mesmo!");
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarUsuarioWeb f1 = new FormConsultarUsuarioWeb();
            f1.Show();
            panel1.Visible = false;
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
