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

namespace personaASD
{
    public partial class Form2 : Form
    {
        Persona persona = new Persona();
        List<Persona> listPersona = new List<Persona>();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            persona.nombre = txtNombre.ToString();
            persona.apellido = txtApellido.ToString();
            persona.dni = (int)txtDni;
        }
    }
}
