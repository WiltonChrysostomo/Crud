using CrudCSharpNoite.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharpNoite.DAL
{
    interface intPessoaDAO
    {
        void CadastrarPessoa(Pessoa pessoa);
        Pessoa PesquisarPessoaPorID(Pessoa pessoa);
        void EditarPessoa(Pessoa pessoa);
        void ExcluirPessoa(Pessoa pessoa);
        List<Pessoa> PesquisarPessoaPorNome(Pessoa pessoa);
    }
}
