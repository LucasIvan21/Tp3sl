using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3
{
    public partial class Form1 : Form
    {
        string Nombre;
        string Apellido;
        int AñoDeNacimiento;

        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtInscripcion_Click(object sender, EventArgs e)
        {
            Nombre = textBoxNombre.Text;
            Apellido = textBoxApellido.Text;
            AñoDeNacimiento = Convert.ToInt32(textBoxFecha.Text);

            if ( 2021 -AñoDeNacimiento >=18)
            {
                lblInscripcion.Text = NombreCompleto() + " se inscribio correctamente";
            }
            else
            {
                lblInscripcion.Text = "Lo sentimos. No cumple con el requisito de edad";
            }
            
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxFecha.Text = "";
            lblInscripcion.Text = "";
        }
    }
}
