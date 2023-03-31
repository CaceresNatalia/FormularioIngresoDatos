using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FomularioIngresoDatos
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
         //Capta cada uno de los datos ingresados mediante el formulario.
            string apellido = txbApellido.Text;
            string nombre = txbNombre.Text;
            string edad = txbEdad.Text;
            string direccion = txbDireccion.Text;

        //Validación para que no queden campos incompletos. Si queda alguno sin llenar, avisa para que lo completen.
        // Si está todo completo, muestra la información en la caja de texto.
            if (txbApellido.BackColor == Color.Red || txbNombre.BackColor == Color.Red || txbEdad.BackColor == Color.Red || txbDireccion.BackColor == Color.Red)
                MessageBox.Show("Por favor complete los campos que faltan");
            else
            txbResultado.Text = "APELLIDO Y NOMBRE: " + apellido + " " + nombre + "\r\n" + " EDAD: " + edad + "\r\n" + " DIRECCION: " + direccion;


        }
        //Validación para que sólo permita ingresar caracteres numéricos.
        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;

        }
        //cada uno de los eventos a continuación hace que se marque en rojo si se deja un campo vacío.
        private void txbApellido_Leave(object sender, EventArgs e)
        {
            if (txbApellido.Text == "")
                txbApellido.BackColor = Color.Red;
            else
                txbApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbNombre_Leave(object sender, EventArgs e)
        {
            if (txbNombre.Text == "")
                txbNombre.BackColor = Color.Red;
            else
                txbNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbEdad_Leave(object sender, EventArgs e)
        {
            if (txbEdad.Text == "")
                txbEdad.BackColor = Color.Red;
            else
                txbEdad.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbDireccion_Leave(object sender, EventArgs e)
        {
            if (txbDireccion.Text == "")
                txbDireccion.BackColor = Color.Red;
            else
                txbDireccion.BackColor = System.Drawing.SystemColors.Control;
        }
        //Cierra el formulario.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
