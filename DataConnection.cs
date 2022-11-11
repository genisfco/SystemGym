using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GenesysGym
{
    internal class DataConnection
    {
        private static MySqlConnection msConnection;

        private static MySqlConnection ConexaoBanco()
        {
            string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

            MySqlConnection msConnection = new MySqlConnection();
            msConnection.ConnectionString = connection_mysql;
            msConnection.Open();

            return msConnection;
        }


        public static DataTable ObterTodosUsuarios()
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuarios";
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();                
                cmd.CommandText = sql;
                msdAdapter = new MySqlDataAdapter (cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();
                return dt;                
            }
            catch (Exception ex)
            {
                throw ex; 
            }

        }


        // FUNÇÕES DA TELA NOVO USER
        public static void NovoUsuario(Usuario user)
        {
            if(existeUserName(user))
            {
                MessageBox.Show("Username já existe!");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios (nome_user, username, senha_user, status_user, nivel_user) VALUES (@nome, @username, @password, @status, @nivel)";

                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@status", user.status);
                cmd.Parameters.AddWithValue("@nivel", user.nivel);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo Usuário Cadastrado!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário!");
            }
        }


        public static bool existeUserName(Usuario user)
        {
            bool res;
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username FROM usuarios WHERE username='"+user.username+"'";
            msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
            msdAdapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }
        // FIM DAS FUNÇÕES TELA NOVO USER
        //
        //
        //
        // FUNÇÕES DA TELA GESTÃO DE USUARIOS

        public static DataTable ObterUsuariosIdNome()
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_user as 'ID Usuário', nome_user as 'Nome Usuário' FROM usuarios";
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable ObterDadosUsuarios(string id)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuarios WHERE id_user ="+id;
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarDadosUsuario(Usuario u)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET nome_user='"+u.nome+"', username='"+u.username+"', senha_user='"+u.password+"', status_user='"+u.status+"', nivel_user="+u.nivel+" WHERE id_user="+u.id;    
                 
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void ExcluirDadosUsuario(string id)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM usuarios WHERE id_user=" + id;

                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // FIM DAS FUNÇOES TELA GESTÃO USUARIOS


        //FUNÇÕES PARA PESQUISA INCLUSAO  E ALTERAÇÃO DE CLIENTES        
        public static DataTable ObterDadosCliente(string cpf)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM cliente WHERE cpf =" + cpf;
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarDadosCliente(Cliente cli)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE cliente SET nmCliente='" + cli.nomecliente + "', cpf='" + cli.cpf + "', rg='" + cli.rg + "', logradouro='" + cli.logradouro + "', numLogradouro='" + cli.numLogradouro + "', cep='" + cli.cep + "', bairro='" + cli.bairro + "', cidade='" + cli.cidade + "', estado='" + cli.estado + "', telefone='" + cli.telefone + "', email='" + cli.email + "' WHERE cpf=" + cli.cpf;

                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();

                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirDadosCliente(string cpf)
        {
            
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {           

                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM cliente WHERE cpf=" + cpf;

                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //FIM DAS FUNÇÕES PARA PESQUISA INCLUSAO  E ALTERAÇÃO DE CLIENTES
        //



        // FUNÇÕES PARA GESTÃO DE FUNCIONARIOS

        public static DataTable ObterDadosFuncionario(string cod)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM funcionario WHERE codfuncionario =" + cod;
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarDadosFuncionario(Funcionario func)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE funcionario SET nome='" + func.nomefunc + "', cpf='" + func.cpffunc + "', rg='" + func.rgfunc + "', logradouro='" + func.logradourofunc + "', numLogradouro='" + func.numLogradourofunc + "', cep='" + func.cepfunc + "', cargo='" + func.cargo + "', bairro='" + func.bairrofunc + "', cidade='" + func.cidadefunc + "', estado='" + func.estadofunc + "', telefone='" + func.telefonefunc + "', email='" + func.emailfunc + "' WHERE codfuncionario=" + func.codfunc;

                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();

                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirDadosFuncionario(string cod)
        {

            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {

                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM funcionario WHERE codfuncionario=" + cod;

                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // FIM DAS FUNÇÕES GESTÃO FUNCIONARIOS

        /// FUNÇÕES PARA TREINOS
        /// 

        public static void NovoTreino(Treino tre)
        {
            
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO treino (grupoMuscular, descrição_exerc, qtde_series, qtde_reps) VALUES (@grupoMuscular, @exerc, @series, @reps)";

                cmd.Parameters.AddWithValue("@grupoMuscular", tre.grupoMuscular);
                cmd.Parameters.AddWithValue("@exerc", tre.exerc);
                cmd.Parameters.AddWithValue("@series", tre.series);
                cmd.Parameters.AddWithValue("@reps", tre.reps);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Treino Cadastrado com Sucesso!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar Treino!");
            }
        }
    }

}
