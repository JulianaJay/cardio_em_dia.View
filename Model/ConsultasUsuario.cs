using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardio_em_dia.Model
{
    public class ConsultasUsuario
    {
        public static bool NovoUsuario(string email, string senha, string nome, string sobrenome, string telefone, string sexo, int cpf, int cep, string uf)
        {
            var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
            bool foiInserido = false;
            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                string senhaCriptografada = Criptografia.CriptografarMD5Senha(senha);


                comando.CommandText = @"
                INSERT INTO Usuario (email, senha, nome, sobrenome, telefone, sexo, cpf, cep, uf) 
                VALUES(@email,@senha, @nome, @sobrenome, @telefone, @sexo, @cpf, @cep, @uf)";
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@senha", senhaCriptografada);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@sobrenome", sobrenome);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@sexo", sexo);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@uf", uf);
                
                var leitura = comando.ExecuteReader();

                foiInserido = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            return foiInserido;
        }

        public static Usuario ObterUsuario(string email, string senha)
        {
            var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
            Usuario usuario = null;

            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = @"
                SELECT * FROM Usuario WHERE email = @email AND senha = @senha";
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@senha", senha);
                var leitura = comando.ExecuteReader();
                while (leitura.Read())
                {
                    usuario = new Usuario();
                    usuario.id = leitura.GetInt32("id");
                    usuario.nome = leitura.GetString("nome");
                    usuario.email = leitura.GetString("email");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            return usuario;
        }

        public static bool VerificarUsuarioExistente(string email)
        {
            var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
            bool usuarioExiste = false;
            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = @"Select * from Usuario Where email = @email";
                comando.Parameters.AddWithValue("@email", email);
                var leitura = comando.ExecuteReader();
                while (leitura.Read())
                {

                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            return usuarioExiste;
        }
    }
}
