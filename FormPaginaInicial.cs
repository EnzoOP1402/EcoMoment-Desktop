using EcoMoment_Desktop.Properties;
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
    public partial class FormPaginaInicial : Form
    {
        public FormPaginaInicial(int p)
        {
            if (p != 1)
            {
                Thread thread = new Thread(new ThreadStart(splashScreen));
                thread.Start();
                Thread.Sleep(1000);
                InitializeComponent();
                thread.Abort();
            }

            if (p==1)
            {
                InitializeComponent();
                btnLogin.Visible = false;
                menuStrip1.Visible = true;
            }

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("\nConectado\n");
            else
                Console.WriteLine("Erro de Conexão");
        }


        private void splashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin(); 
            //Fazer uma verificação por ponteiro no construtor do form login
            fl.Show();
            this.Hide();
        }

        private void excluirUsuárioADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioAdm fe = new FormExcluirAtualizarUsuarioAdm(2);
            fe.Show();
        }

        private void atualizarDadosADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioAdm fa = new FormExcluirAtualizarUsuarioAdm(1);
            fa.MdiParent = this;
            fa.Show();
        }

        private void consultarDadosDeUsuáriosADMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaAdm fc = new FormConsultaAdm();
            fc.MdiParent = this;
            fc.Show();
        }

        private void excluirUsuárioWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb fe = new FormExcluirAtualizarUsuarioWeb(2);
            fe.Show();
        }

        private void atualizarUsuárioWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAtualizarUsuarioWeb fa = new FormExcluirAtualizarUsuarioWeb(1);
            fa.MdiParent = this;
            fa.Show();
        }

        private void consultarDadosDeUisuáriosWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarUsuarioWeb fc = new FormConsultarUsuarioWeb();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}
