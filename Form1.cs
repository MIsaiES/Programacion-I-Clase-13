using Programacion_I_Clase_13.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_I_Clase_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int intentos = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioTextbox.Text.ToLower();
            string contrasenia = ContraseniaTextbox.Text.ToLower();
            

            if (intentos>=2)
            {
                MessageBox.Show("Ya no le Quedan mas Intentos");
                button3.Enabled = false;
            }
            else if (usuario.Equals("admin") && contrasenia.Equals("admin"))
            {
                fmrRegistro fmrReg = new fmrRegistro();
                fmrReg.Show();
            }
            else if (usuario == "" || contrasenia == "")
            {
                MessageBox.Show("No puede dejar las Casillas en Blanco");
            }
            else
            {
                MessageBox.Show($"Usuario o Contraseña Erroneos\nQuedan {2-intentos}");
                UsuarioTextbox.Clear();
                ContraseniaTextbox.Clear();
                intentos++;
            }
        }
    }
}

