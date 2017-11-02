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
    public partial class loginDiag : Form
    {
        login l = new login();
        public loginDiag(String msj, bool y, bool a, bool n)
        {
            InitializeComponent();
            mensaje.Enabled = false;
            mensaje.Text = msj;
            yes.Visible = y;
            aceptar.Visible = a;
            no.Visible = n;
            
        }

        private void loginDiag_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
            this.Height = this.Height + 30;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
