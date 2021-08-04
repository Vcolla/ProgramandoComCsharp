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
    }
}
