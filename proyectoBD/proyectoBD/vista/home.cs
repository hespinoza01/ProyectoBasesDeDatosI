using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBD
{
    public partial class home : Form
    {

        public home(string id,string name,string last)
        {
            InitializeComponent();
            toolTip1.SetToolTip(cerrarSesion, "Cerrar Sesion");
            labelNombre.Text = name;
            labelApellido.Text = last;
            labelId.Text = id;
        }

        private void home_Load(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login l = new login();
            l.Show();
        }

    }
}
