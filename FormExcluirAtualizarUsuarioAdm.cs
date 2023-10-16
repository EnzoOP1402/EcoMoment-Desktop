﻿using MySql.Data.MySqlClient;
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
    public partial class FormExcluirAtualizarUsuarioAdm : Form
    {
        int op = 0;
        public FormExcluirAtualizarUsuarioAdm(int n1)
        {
            InitializeComponent();

            UsuarioAdm uadm = new UsuarioAdm();
            //Abriu conexao
            MySqlDataReader reader = uadm.consultarTodosUsuariosAdm();
            while (reader.Read())
            {
                comboBoxExcluirAdm.Items.Add(reader["idUsuarioAdm"]);
            }
            DAO_Conexao.con.Close();//Fechou conexao

            if (n1 == 1)
            {
                this.Text = "Atualizar usuário ADM";
                btnExcluirAdm.Text = "Atualizar";
                label5.Text = "Atualizar Usuário ADM";
                gpbxExcluirAdm.Text = "Atualizar";
                this.Text = "Atualizar Usuário ADM";
                op = 1;
            }
            else
            {
                btnExcluirAdm.Text = "Excluir";
                op = 2;
            }
        }
        private void comboBoxExcluirAdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (op == 2)
            {
                txtEmailExcluirAdm.Enabled = false;
                txtNomeExcluirAdm.Enabled = false;
                txtSenhaExcluirAdm.Enabled = false;
            }
            try
            {
                UsuarioAdm uadm = new UsuarioAdm();
                //Abriu conexao
                MySqlDataReader r = uadm.consultarUsuarioAdmId(int.Parse(comboBoxExcluirAdm.SelectedItem.ToString()));
                while (r.Read())
                {
                    txtNomeExcluirAdm.Text = r["NomeAdm"].ToString();
                    txtEmailExcluirAdm.Text = r["EmailAdm"].ToString();
                    txtSenhaExcluirAdm.Text = r["SenhaAdm"].ToString();
                }
                DAO_Conexao.con.Close();//Fechou conexao
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar o Usuário");
            }
        }

        private void btnExcluirAdm_Click(object sender, EventArgs e)
        {
            if (op == 2)
            {
                try
                {
                    UsuarioAdm uadm = new UsuarioAdm();
                    if (uadm.excluirUsuarioAdm(int.Parse(comboBoxExcluirAdm.SelectedItem.ToString())))
                    {
                        MessageBox.Show("Usuário excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir Usuário Adm. Tente novamente.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de execução.");
                }
            }
            else if (op == 1)
            {
                try
                {
                    UsuarioAdm uadm = new UsuarioAdm();
                    if (uadm.atualizarUsuarioAdm(int.Parse(comboBoxExcluirAdm.SelectedItem.ToString()), txtNomeExcluirAdm.Text, txtEmailExcluirAdm.Text, txtSenhaExcluirAdm.Text))
                    {
                        MessageBox.Show("Usuário atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar Usuário Adm. Tente novamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de execução.");
                }
            }
        }
    }
}