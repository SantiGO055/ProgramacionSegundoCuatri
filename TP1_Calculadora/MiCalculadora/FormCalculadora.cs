using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CalculadoraTP
{
    public partial class FormCalculadora : Form
    {
        int flagBinario = 0;
        int flagDecimal = 0;
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            
            if (lblResultado.Text == string.Empty) // this.txtNumero1.Text = string.Empty;
            {
                MessageBox.Show("No hay ningun numero para convertir a binario");
            }
            if (lblResultado.Text != string.Empty && flagBinario == 0)
            {
                int.TryParse(lblResultado.Text, out int auxInt);
                if (auxInt>=0)
                {
                    lblResultado.Text = Entidades.Numero.DecimalBinario(lblResultado.Text);
                    this.flagBinario = 1;
                    this.flagDecimal = 0;
                }
                else
                {
                    MessageBox.Show("No se puede convertir el numero");
                }
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            int.TryParse(lblResultado.Text, out int aux);
            if (lblResultado.Text == string.Empty)
            {
                MessageBox.Show("No hay ningun numero para convertir a binario");
            }
            else if (lblResultado.Text != string.Empty && flagDecimal == 0 && aux >= 0)
            {
                lblResultado.Text = Entidades.Numero.BinarioDecimal(lblResultado.Text);
                flagBinario = 0;
                flagDecimal = 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string aux;
            double resultado;
            int auxNumero1, auxNumero2;
            if ((this.txtNumero1.Text == string.Empty || this.txtNumero2.Text == string.Empty) ||
                (!int.TryParse(txtNumero1.Text, out auxNumero1) || !int.TryParse(txtNumero2.Text, out auxNumero2)))
            {
                MessageBox.Show("No hay numero ingresado o ingreso letras");
            }
            else
            {
                aux = cmbOperador.Text;
                resultado = Operar(txtNumero1.Text, txtNumero2.Text, aux);
                aux = Convert.ToString(resultado);
                lblRespuesta.Text = "Respuesta: ";
                lblResultado.Text = aux;
                this.flagBinario = 0;
                this.flagDecimal = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.ResetText();
            lblResultado.ResetText();
            this.flagBinario = 0;
            this.flagDecimal = 0;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            resultado=Calculadora.Operar(num1, num2, operador);
            return resultado;

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStripArchivo_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

