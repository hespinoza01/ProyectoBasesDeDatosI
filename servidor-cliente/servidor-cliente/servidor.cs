using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using servidor_cliente.clases;

namespace servidor_cliente
{
    public partial class Servidor : Form
    {
        bool activate = false;

        public Servidor()
        {
            InitializeComponent();
            statusServer.Text = "Servidor Detenido...";
            //stopServer.Enabled = false;
        }

        private void startServer_Click(object sender, EventArgs e)
        {
            if (!activate)
            {
                activate = true;
                statusServer.Text = "Servidor Iniciado...";
                serverPrototype2 s = new serverPrototype2();
                s.startServer(txtPuerto.Text);
            }
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            if (activate){
                activate = false;
                statusServer.Text = "Servidor Detenido...";
            }
        }


        
    }
}
