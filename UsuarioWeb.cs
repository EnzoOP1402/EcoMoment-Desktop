using MySql.Data.MySqlClient;
using Projeto_DuplinhaFeroz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoMoment_Desktop
{
    internal class UsuarioWeb
    {
        private string nome;
        private string email;
        private string senha;

        public UsuarioWeb() { }
        public UsuarioWeb(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public bool consultarUsuarioWeb(int id)
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from EcoMomentBD_UsuarioAdm where idUsuarioAdm=" + id + "", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return existe;
        }

        public MySqlDataReader consultarTodosUsuariosWeb()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from EcoMomentBD_UsuarioAdm", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public bool excluirUsuarioWeb(int id)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("delete from EcoMomentBD_UsuarioAdm where idUsuarioAdm = " + id + ")", DAO_Conexao.con);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public bool atualizarUsuarioWeb()
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("update from EcoMomentBD_UsuarioAdm set (NomeAdm, EmailAdm, SenhaAdm) values  (" + nome + ", '" + email + "', '" + senha + "')", DAO_Conexao.con);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
