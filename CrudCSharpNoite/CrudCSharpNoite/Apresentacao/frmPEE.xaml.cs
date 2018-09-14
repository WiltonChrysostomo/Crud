using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CrudCSharpNoite.Apresentacao
{
    /// <summary>
    /// Interaction logic for frmPEE.xaml
    /// </summary>
    public partial class frmPEE : Window
    {
        public frmPEE()
        {
            InitializeComponent();
        }

        private void btnPesquisarPorID_Click(object sender, RoutedEventArgs e)
        {
            List<String> dadosPessoa = new List<string>();
            dadosPessoa.Add(txbId.Text);
            dadosPessoa.Add("");
            dadosPessoa.Add("");
            dadosPessoa.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.Pessoa pessoa = controle.PesquisarPessoaPorID(dadosPessoa);
            txbNome.Text = pessoa.nome;
            txbRg.Text = pessoa.rg;
            txbCpf.Text = pessoa.cpf;
            if( pessoa.id == 0)
            {
                MessageBox.Show("Não existe esse registro");
            }
        }
    }
}
