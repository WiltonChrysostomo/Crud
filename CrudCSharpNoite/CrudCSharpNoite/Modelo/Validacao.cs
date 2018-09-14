using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharpNoite.Modelo
{
    public class Validacao
    {

        public String mensagem;
        public int id;

        public void ValidarDadosPessoa(List<String> dadosPessoa)
        {
            this.mensagem = "";

            if (dadosPessoa[1].Length > 30)

                this.mensagem = " nome com mais de 30 caracteres \n";

            if (dadosPessoa[2].Length > 10)

                this.mensagem += " RG com mais de 10 caracteres \n";

            if (dadosPessoa[3].Length > 13)

                this.mensagem += " CPF com mais de 13 caracteres \n";
            // para validar campo numérico tenho que subir string, converter
            try
            {
                this.id = Convert.ToInt32(dadosPessoa[0]);

            }
            catch (FormatException e)
            {

                this.mensagem += " ID inválido";
            }
        }
    }



}
