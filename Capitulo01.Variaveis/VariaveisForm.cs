using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {

        int _x;
        int _w;
        int _y;
        int _z;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void resultadoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            int c = 10;
            int d = 13;
            string @class = "teste";

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add($"c = {c}");
            resultadoListBox.Items.Add(string.Concat("d = ", d));
            resultadoListBox.Items.Add(new string('-',10));
            resultadoListBox.Items.Add(@class);
            // nova linha para forms e web
            //resultadoListBox.Items.Add(@class + Environment.NewLine + @class);
            resultadoListBox.Items.Add(new string('-', 10));
            resultadoListBox.Items.Add("c * d =" + (c * d));
            resultadoListBox.Items.Add("c / d =" + (c / d));
            resultadoListBox.Items.Add("d % a =" + (d % a));

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("X =" + (x));

            x -= 3;

            resultadoListBox.Items.Add("X =" + (x));
            
        }

        private void incrementaisDescrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;

            resultadoListBox.Items.Add("exemplo pré-incremental");
            resultadoListBox.Items.Add("a =" + (a));
            resultadoListBox.Items.Add("2 + ++a = " + (2+ ++a));
            resultadoListBox.Items.Add("a =" + (a));

            a = 5;

            resultadoListBox.Items.Add("exemplo pós-incremental");
            resultadoListBox.Items.Add("a =" + (a));
            resultadoListBox.Items.Add("2 + a++ = " + (2 + a++));
            resultadoListBox.Items.Add("a =" + (a));
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _x = 32;
            _w = 45;
            _y = 16;
            _z = 32;

            MostrarVariaveis();

            resultadoListBox.Items.Add("w <= x = " + (_w <= _x));
            resultadoListBox.Items.Add("x == z = " + (_x == _z));
            resultadoListBox.Items.Add("x != z = " + (_x != _z));

        }
        
        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _x = 32;
            _w = 45;
            _y = 16;
            _z = 32;

            MostrarVariaveis();

            resultadoListBox.Items.Add("_w <= _x || _y == 16 = " + (_w <= _x || _y == 16));
            resultadoListBox.Items.Add("_x == _z && _z != _x = " + (_x == _z && _z != _x));
            resultadoListBox.Items.Add("!(_y > _w) = " + (!(_y > _w)));
        }

        private void MostrarVariaveis()
        {
            resultadoListBox.Items.Add("x = " + _x);
            resultadoListBox.Items.Add("w = " + _w);
            resultadoListBox.Items.Add("y = " + _y);
            resultadoListBox.Items.Add("z = " + _z);
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int ano = 2014; ano <= 2016; ano++)
            {
                resultadoListBox.Items.Add("Ano " + ano);

                resultadoListBox.Items.Add(string.Format("O Ano {0} é bissexto teste1? {1}.", ano, ano % 4 == 0 ? "Sim" : "Não"));
                resultadoListBox.Items.Add(string.Format("O Ano {0} é bissexto teste2? {1}.", ano, DateTime.IsLeapYear(ano) ? "Sim" : "Não"));
            }

        }
    }
}
