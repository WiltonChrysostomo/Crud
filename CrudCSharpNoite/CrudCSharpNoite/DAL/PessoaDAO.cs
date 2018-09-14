using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharpNoite.DAL
{
    public class PessoaDAO : intPessoaDAO
    {
        public String mensagem;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();
        public void CadastrarPessoa(Modelo.Pessoa pessoa)
        {

            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into pessoas
                    (nome, rg, cpf)
                    values(@nome, @rg, @cpf)";
            cmd.Parameters.AddWithValue("@nome", pessoa.nome);
            cmd.Parameters.AddWithValue("@rg", pessoa.rg);
            cmd.Parameters.AddWithValue("@cpf", pessoa.cpf);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Pessoa cadastrada com sucesso !!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }

        }

        public Modelo.Pessoa PesquisarPessoaPorID(Modelo.Pessoa pessoa)
        {

            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select *from pessoas
                               where id = @id";
                    
            cmd.Parameters.AddWithValue("@id", pessoa.id);
           

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    pessoa.nome = dataReader["nome"].ToString();
                    pessoa.rg = dataReader["rg"].ToString();
                    pessoa.cpf = dataReader["cpf"].ToString();
                }

                else
                {
                    pessoa.id = 0;
                }

                dataReader.Close();
                conexaoBD.Desconectar();
                
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return pessoa;
        }

        public void EditarPessoa(Modelo.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPessoa(Modelo.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public List<Modelo.Pessoa> PesquisarPessoaPorNome(Modelo.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
