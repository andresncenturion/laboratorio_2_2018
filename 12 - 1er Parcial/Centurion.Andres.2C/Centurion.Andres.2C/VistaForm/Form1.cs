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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        DirectorTecnico directorTecnico;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {            
            directorTecnico = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, int.Parse(numericUpDownEdad.Text), int.Parse(numericUpDownDni.Text), int.Parse(numericUpDownExperiencia.Text));
            MessageBox.Show("Se ha creado el DT!");
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {

            if(ReferenceEquals(directorTecnico, null))
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            }
            else
            {
                if (directorTecnico.ValidarAptitud() == true)
                {
                    MessageBox.Show("El DT es apto");
                }
                else
                {
                    MessageBox.Show("El DT NO es apto");
                }
            }            
        }
    }
}
