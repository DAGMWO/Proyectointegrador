using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactosPlus.Presentation
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txtMenNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMenNombre.Text.Length > 0)
            {
                if (txtMenApellido.Text.Length > 0)
                {
                    //guardar usando programacion
                }
                else
                {
                    MessageBox.Show("Escribe tu apellido");
                }
            }
            else
            {
                MessageBox.Show("Escribe tu nombre");
            }
        }
    }
}
