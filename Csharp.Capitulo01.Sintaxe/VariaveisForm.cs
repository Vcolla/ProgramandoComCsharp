using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp.Capitulo01.Sintaxe
{
    public partial class VariaveisForm : Form
    {
        int y = 16;
        int w = 45;
        int z = 32;
        int x = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aritméticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 42;
            int y;
            string nome = "Vítor";
            char letra = 'a';
            var dataNascimento = new DateTime(2000, 01, 21);
            bool aprovado = true;
            var media = 2M;
            double distancia = 1.2d;
            float altura = 0.8f;
            long populacao = 2013;
            var a = 2;
            int b = 6, c = 10, d = 13;
            //c = 9.9m; 

            decimal bim1 = 2.9m;

            string @class = "3A";

            Object objeto = "texto";
            objeto = 1;

            resultadoListBox1.Items.Clear();

            resultadoListBox1.Items.Add("a =" + a);
            resultadoListBox1.Items.Add(string.Concat("b =", b));// "c ="
           // resultadoListBox1.Items.Add(string.Format("c = {0}, d ={1}", c, d));
            resultadoListBox1.Items.Add(string.Format("c = {0}", c ));
            resultadoListBox1.Items.Add($"d = {d}");
            
            resultadoListBox1.Items.Add($"c * d = {c * d}");            
            resultadoListBox1.Items.Add($"d / a = {d / a}");            
            resultadoListBox1.Items.Add($"d % a = {d % a}");            
            
            

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resultadoListBox1.Items.Clear();

            var x = 5;
            resultadoListBox1.Items.Add("x =" + x);
            //x = x - 3;
            x -= 3;
            resultadoListBox1.Items.Add("x =" + x);




        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox1.Items.Clear();

            int a;
            a = 5;

            resultadoListBox1.Items.Add("Exemplo de pré-incremental");
            resultadoListBox1.Items.Add("a =" + a);
            resultadoListBox1.Items.Add($"2 + ++a ={2 + ++a}");
            resultadoListBox1.Items.Add("a =" + a);

            a = 5;
            resultadoListBox1.Items.Add("------------------------------------");


            resultadoListBox1.Items.Add("Exemplo de pós-incremental");
            resultadoListBox1.Items.Add("a =" + a);
            resultadoListBox1.Items.Add($"2 + a++ ={2 + a++}");
            resultadoListBox1.Items.Add("a =" + a);




        }

        private void boleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirVariaveis();

            resultadoListBox1.Items.Add($"w <= x = {w <= x}");
            resultadoListBox1.Items.Add($"x == z = {x == z}");
            resultadoListBox1.Items.Add($"x != z = {x != z}");
        }

        private void ExibirVariaveis()
        {
            resultadoListBox1.Items.Add("x =" + x);
            resultadoListBox1.Items.Add("y =" + y);
            resultadoListBox1.Items.Add("w =" + w);
            resultadoListBox1.Items.Add("z =" + z);

            resultadoListBox1.Items.Add(new string('-', 50));
        }

        private void lógicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirVariaveis();

            resultadoListBox1.Items.Add($"w <= x || y == 16 = {w <= x || y == 16}");
            resultadoListBox1.Items.Add($"w <= x && y != 16 = {w <= x && y != 16}");
            resultadoListBox1.Items.Add($"!(y > w) = {!(y > w)}");



        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2014;
            resultadoListBox1.Items.Add($"O ano{ano} é bissexto?{(ano % 4 == 0 ? "Sim" : "Não")}");

            ano = 2016;
            resultadoListBox1.Items.Add($"O ano{ano} é bissexto?{(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}");

            //var resposta = "";
            //if (DateTime.IsLeapYear(ano))

            //{
               // resposta = "Sim";
            //}
            //else
            //{
              //  resposta = "Não";
            //}
        }
        
	

	
    }
}
