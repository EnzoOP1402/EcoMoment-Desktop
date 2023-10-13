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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            if(txtEmailCadastrar.Text != "" && txtNomeCadastrar.Text != "" && txtSenha2Cadastrar.Text != "" && txtSenhaCadastrar.Text != "")
            {
                if (txtSenhaCadastrar.Text.Equals(txtSenha2Cadastrar.Text))
                {
                    try
                    {
                        UsuarioAdm uAdm = new UsuarioAdm(txtNomeCadastrar.Text, txtEmailCadastrar.Text, txtSenha2Cadastrar.Text);
                        uAdm.cadastrarUsuarioAdm();
                        MessageBox.Show("Sucesso ao cadastrar usuário Adm");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar usuário Adm");
                    }
                }
                else
                {
                    MessageBox.Show("Ambas as senhas devem ser iguais.");
                }
                
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio.");
            }
        }
    }
}
