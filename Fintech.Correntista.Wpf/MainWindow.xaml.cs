using Fintech.Dominio;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fintech.Correntista.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public Cliente ClienteSelecionado { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PopularControles();
        }

        private void PopularControles()
        {
            sexoComboBox.Items.Add(Sexo.Feminino);
            sexoComboBox.Items.Add(Sexo.Masculino);
            sexoComboBox.Items.Add(Sexo.Outro);

            tipoContaComboBox.Items.Add(TipoConta.ContaCorrente);
            tipoContaComboBox.Items.Add(TipoConta.ContaEspecial);
            tipoContaComboBox.Items.Add(TipoConta.Poupanca);

            var banco1 = new Banco();
            banco1.Nome = "Banco 1";
            banco1.Numero = 915;

            bancoComboBox.Items.Add(banco1);
            bancoComboBox.Items.Add(new Banco() {Nome ="Banco 2", Numero = 923 });

            clientesDataGrid.ItemsSource = Clientes;
                
         }

        private void incluirClienteButton_Click(object sender, RoutedEventArgs e)
        {
            //Cliente cliente = new Cliente();
            // var cliente = new Cliente();
            Cliente cliente = new();

            cliente.CPF = cpfTextBox.Text;
            cliente.Nome = NomeTextBox.Text;
            cliente.DataNascimento = Convert.ToDateTime (DataNascimentoTextBox.Text);
            cliente.Sexo = (Sexo)sexoComboBox.SelectedItem;

            var endereco = new Endereco();
            endereco.Cidade = CidadeTextBox.Text;
            endereco.Logradouro = LougradouroTextBox.Text;
            endereco.Numero = NumeroTextBox.Text;
            endereco.Cep = CepTextBox.Text;
            
            cliente.EnderecoResidencial = endereco;

            Clientes.Add(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso.");
            LimparControlesCliente();
            clientesDataGrid.Items.Refresh();
            pesquisaClienteTabItem.Focus();


        }
        /// <summary>
        /// Limpa os controles da Aba Cadastro de Clientes.
        /// </summary>

        private void LimparControlesCliente()
        {
            cpfTextBox.Clear();
            NomeTextBox.Text = "";
            DataNascimentoTextBox.Text = String.Empty;
            sexoComboBox.SelectedIndex = -1;
            NumeroTextBox.Clear();
            CidadeTextBox.Clear();
            CepTextBox.Clear();
            LougradouroTextBox.Clear();

           
        }

        private void SelecionarClientesButtonClick(object sender, RoutedEventArgs e)
        {
            var BotaoClicado = (Button)sender;
            var clienteSelecionado = BotaoClicado.DataContext;
            
            ClienteSelecionado = (Cliente)clienteSelecionado;

            clienteTextBox.Text = $"{ClienteSelecionado.Nome} - {ClienteSelecionado.CPF}";

            contasTabItem.Focus();
            
        }

        private void TipoContaComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tipoContaComboBox.SelectedIndex == -1) return;
            var tipoConta = (TipoConta)tipoContaComboBox.SelectedItem;

            if (tipoConta == TipoConta.ContaEspecial)
            {
                limiteDockPanel.Visibility = Visibility.Visible;
                limiteTextBox.Focus();
            }
            else
            {
                limiteDockPanel.Visibility = Visibility.Collapsed;
            }
        }

        private void incluirContaButton_Click(object sender, RoutedEventArgs e)
        {
            Conta conta = null;

            var agencia = new Agencia();
            agencia.Banco = (Banco)bancoComboBox.SelectedItem;
            agencia.Numero = Convert.ToInt32(numeroAgenciaTextBox.Text);
            agencia.DigitoVerificador = Convert.ToInt32(dvAgenciaTextBox.Text);

            var numero = Convert.ToInt32(numeroAgenciaTextBox.Text);
            var digitoVerificador = dvContaTextBox.Text;

            switch ((TipoConta)tipoContaComboBox.SelectedItem)

            {
                case TipoConta.ContaCorrente:
                    conta = new ContaCorrente(agencia, numero, digitoVerificador);
                    break;
                case TipoConta.ContaEspecial:
                    var limite = Convert.ToDecimal(limiteTextBox.Text);
                    conta = new ContaEspecial(agencia, numero, digitoVerificador, limite);
                    break;
                case TipoConta.Poupanca:
                    conta = new Poupanca(agencia, numero, digitoVerificador);
                    break;
                default:
                    break;

            }
            ClienteSelecionado.Contas.Add(conta);

            MessageBox.Show("Conta adicionada com sucesso");
            LimparControlesContas();
            clientesDataGrid.Items.Refresh();
            clientesTabItem.Focus();
           // pesquisaClienteTabItem.Focus();
        }

        private void LimparControlesContas()
        {
            clienteTextBox.Clear();
            bancoComboBox.SelectedItem = -1;
            numeroAgenciaTextBox.Clear();
            dvAgenciaTextBox.Clear();
            numeroContaTextBox.Clear();
            dvContaTextBox.Clear();
            tipoContaComboBox.SelectedIndex = -1;
            limiteTextBox.Clear();
        }
    }
}
