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
    /// Interaction logic for frmCadastro.xaml
    /// </summary>
    public partial class frmCadastro : Window
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            List<String> dadoPessoa = new List<string>();
            dadoPessoa.Add("0");
            dadoPessoa.Add(txbNome.Text);
            dadoPessoa.Add(txbRg.Text);
            dadoPessoa.Add(txbCpf.Text);

            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastroPessoa(dadoPessoa);
            MessageBox.Show(controle.mensagem);
        }
    }
}
