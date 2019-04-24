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
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void Formulario3_Load(object sender, EventArgs e)
        {
            txtName.Text = "Samuel Alexander Baires";
            txtCarnet.Text = "27-2098-2012";
            txtMateria.Text="Programacion 1";
            txtciclo.Text="01-2019";
    }
}
}
