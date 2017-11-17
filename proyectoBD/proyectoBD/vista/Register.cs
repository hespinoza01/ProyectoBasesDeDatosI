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
    public partial class Register : Form
    {
        bool edt = false;
        string n, a, nu, p, index;
        Image pic;
        
        public Register(bool e, string index)
        {
            InitializeComponent();
            lateral.Visible = false;
            bac.Visible = false;
            pass.isPassword = true;
            confirPass.isPassword = true;
            edt = e;
            this.index = index;
        }


        /***************************/
        /* * * * * EVENTOS * * * * */
        /***************************/

        private void Register_Load(object sender, EventArgs e)
        {
            Console.WriteLine(edt);
            if (edt)
            {
                Edit();
            }
        }


        private void edit_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(open.FileName);
                perfil.Image = imagen;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (CVacios())
                new popup("Campos vacios...", popup.AlertType.error);
            else
            {
                if (pass.Text.Equals(confirPass.Text))
                {

                    if (edt == true)
                        editInfo();
                    else
                        saveNew();


                    this.Close();
                }
                else
                    new popup("Contraseñas no coinciden...", popup.AlertType.error);
            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            if(val())
            {
                bunifuTransition1.ShowSync(lateral);
                bac.Visible = true;
            }
            else
            {
                new popup("Rellenar todos los campos", popup.AlertType.warning);
            }
        }

        private void nomUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                pass.Focus();
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            pass.isPassword = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                confirPass.Focus();
        }

        private void confirPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            confirPass.isPassword = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                registrar_Click(null, null);
        }

        private void apellidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                next_Click(null, null);
        }

        private void nombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                apellidoTxt.Focus();
        }

        private void bac_Click(object sender, EventArgs e)
        {
            lateral.Visible = false;
            bac.Visible = false;
        }


        /***************************/
        /* * * * * MÉTODOS * * * * */
        /***************************/

        private bool CVacios()
        {
            bool vacio = false;

            if (nomUser.Text.Equals("")) { vacio = true; }

            if (pass.Text.Equals("")) { vacio = true; }

            if (confirPass.Text.Equals("")) { vacio = true; }
            Console.Write(vacio);
            return vacio;
        }

        public bool val()
        {
            bool val = true;

            if (nombreTxt.Text.Equals("")) { val = false; }
            if(apellidoTxt.Text.Equals("")) { val = false; }

            return val;
        }


        //crear nuevo usuario
        void saveNew()
        {

            new user(
                nombreTxt.Text,
                apellidoTxt.Text,
                pass.Text,
                nomUser.Text,
                perfil.Image,
                user.Accion.insertar
            );

        }

        public void Edit()
        {
            nombreTxt.Text = n;
            apellidoTxt.Text = a;
            nomUser.Text = nu;
            pass.Text = p;
            perfil.Image = pic;

        }

        public void setInfo(string nom, string ape, string nUs, string ps, Image pct)
        {
            this.n = nom;
            this.a = ape;
            this.nu = nUs;
            this.p = ps;
            this.pic = pct;
        }

        public void editInfo()
        {
            new user(
                nombreTxt.Text,
                apellidoTxt.Text,
                pass.Text,
                nomUser.Text,
                perfil.Image,
                user.Accion.editar
            );
           
        }
        
        
    }
}
