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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EcoMoment_Desktop
{
    public partial class FormConsultaEmail : Form
    {
        public FormConsultaEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioWeb uWeb = new UsuarioWeb();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite um email");
            }
            else
            {
                try
                {
                    MySqlDataReader reader = uWeb.consultarUsuarioWebEmail(textBox1.Text.ToString());
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["idUsuarioWeb"].ToString(), reader["NomeWeb"].ToString(), reader["EmailWeb"].ToString(), reader["SenhaWeb"].ToString());
                    }
                    DAO_Conexao.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar usuário");
                }
            }
        }
    }
}
