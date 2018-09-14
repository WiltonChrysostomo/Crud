using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharpNoite.Modelo
{
    public class Controle
    {
        public String mensagem;

        public void CadastroPessoa(List<String> dadoPessoa)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosPessoa(dadoPessoa);
            if (validacao.mensagem.Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = dadoPessoa[1];
                pessoa.rg = dadoPessoa[2];
                pessoa.cpf = dadoPessoa[3];
                DAL.PessoaDAO pessoaDAO = new DAL.PessoaDAO();
                pessoaDAO.CadastrarPessoa(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
            public Pessoa PesquisarPessoaPorID(List<String> dadosPessoa)
            {
                this.mensagem = "";
                Pessoa pessoa = new Pessoa();
                Validacao validacao = new Validacao();
                validacao.ValidarDadosPessoa(dadosPessoa);
                if (validacao.mensagem.Equals(""))
                {
                    
                    pessoa.id = validacao.id;
                    DAL.PessoaDAO pessoaDAO = new DAL.PessoaDAO();
                    pessoa = pessoaDAO.PesquisarPessoaPorID(pessoa);

                }
                else
                {
                    this.mensagem = validacao.mensagem;
                }
                return pessoa;
            }
    }   
}
