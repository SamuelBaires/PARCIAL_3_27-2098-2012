using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtCantidad.Text);
            b = Convert.ToDouble(txtCuantopor.Text);
            r = a % b;
            rdbAgregar = r.ToString();
            rdbNoagregar = txtCantidad;
            txtCuantopor = txtCantidad;
        }
    }
}
