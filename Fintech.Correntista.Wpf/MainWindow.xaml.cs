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
    }
}
