using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFormulario
{
    public partial class Form1 : Form
    {
        model model;
        public Form1()
        {
            InitializeComponent();
            this.model = new model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.model.Somar(Convert.ToDouble(maskedTextBox1.Text));

        }//somar

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.model.Subtrair(Convert.ToDouble(maskedTextBox1.Text));

        }//subtrair

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.model.Multiplicar(Convert.ToDouble(maskedTextBox1.Text));

        }//multiplicar

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.model.Dividir(Convert.ToDouble(maskedTextBox1.Text));

        }//dividir

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//masked

        private void button5_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text = "" + this.model.Potencia(Convert.ToDouble(maskedTextBox1.Text));

        }//potencia

        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.model.Raiz(Convert.ToDouble(maskedTextBox1.Text));
        }//raiz
    }
}
