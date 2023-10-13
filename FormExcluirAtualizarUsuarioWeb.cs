using MySql.Data.MySqlClient;
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
    public partial class FormExcluirAtualizarUsuarioWeb : Form
    {
        int op = 0;

        public FormExcluirAtualizarUsuarioWeb(int p)
        {
            InitializeComponent();

            UsuarioWeb uWeb = new UsuarioWeb();
            //Abriu conexao
            MySqlDataReader reader = uWeb.consultarTodosUsuariosWeb();
            while (reader.Read())
            {
                comboBoxExcluirWeb.Items.Add(reader["idUsuarioWeb"]);
            }
            DAO_Conexao.con.Close();//Fechou conexao

            if (p == 1)
            {
                btnExcluirWeb.Text = "Atualizar";
                label5.Text = "Atualizar Usuário";
                gpbxExcluirWeb.Text = "Atualizar";
                this.Text = "Atualizar Usuário Web";
                op = 1;
            }
            else
            {
                btnExcluirWeb.Text = "Excluir";
                op = 2;
            }
        }

        private void comboBoxExcluirWeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (op == 2)
            {
                txtEmailExcluirWeb.Enabled = false;
                txtNomeExcluirWeb.Enabled = false;
                txtSenhaExcluirWeb.Enabled = false;
            }
            try
            {
                UsuarioWeb uWeb = new UsuarioWeb();
                //Abriu conexao
                MySqlDataReader r = uWeb.consultarUsuarioWeb(int.Parse(comboBoxExcluirWeb.SelectedItem.ToString()));
                while (r.Read())
                {
                    txtNomeExcluirWeb.Text = r["NomeWeb"].ToString();
                    txtEmailExcluirWeb.Text = r["EmailWeb"].ToString();
                    txtSenhaExcluirWeb.Text = r["SenhaWeb"].ToString();
                }
                DAO_Conexao.con.Close();//Fechou conexao
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar o Usuário");
            }
        }

        private void btnExcluirWeb_Click(object sender, EventArgs e)
        {
            if (op == 2)
            {
                try
                {
                    UsuarioWeb uWeb = new UsuarioWeb();
                    uWeb.excluirUsuarioWeb(int.Parse(comboBoxExcluirWeb.SelectedItem.ToString()));
                    MessageBox.Show("Usuário excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir Usuário Web");
                }
            }else if (op == 1)
            {
                try
                {
                    UsuarioWeb uWeb = new UsuarioWeb();
                    uWeb.atualizarUsuarioWeb(txtNomeExcluirWeb.Text, txtEmailExcluirWeb.Text, txtSenhaExcluirWeb.Text);
                    MessageBox.Show("Usuário atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar usuário web");
                }
            }
        }
    }
}
