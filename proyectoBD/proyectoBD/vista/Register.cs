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
        string n, a, nu, p;
        Image pic;
        int index;
        
        public Register(bool e, int index)
        {
            InitializeComponent();
            lateral.Visible = false;
            bac.Visible = false;
            pass.isPassword = true;
            confirPass.isPassword = true;
            edt = e;
            this.index = index;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(open.ShowDialog() == DialogResult.OK){
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
            if (CVacios()){
                popup p = new popup("Campos vacios...", popup.AlertType.error);

            }else{
                if (pass.Text.Equals(confirPass.Text)){

                    if (edt==true)
                    {
                        editInfo();
                    }
                    else
                    {
                        saveNew();
                    }
                    
                    this.Close();

                }else{
                    popup p = new popup("Contraseñas no coinciden...", popup.AlertType.error);
                }
            }
            
        }

        private bool CVacios()
        {
            bool vacio = false;

            if (nomUser.Text.Equals("")) { vacio = true; }    

            if (pass.Text.Equals("")) { vacio = true; }  

            if (confirPass.Text.Equals("")) { vacio = true; }
            Console.Write(vacio);
            return vacio;
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
                popup p = new popup("Rellenar todos los campos", popup.AlertType.error);
            }
        }

        public bool val()
        {
            bool val = true;

            if (nombreTxt.Text.Equals("")) { val = false; }
            if(apellidoTxt.Text.Equals("")) { val = false; }

            return val;
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

        void saveNew()
        {
            user u = new user();
            datosUser du = new datosUser();

            u.Nombre = nombreTxt.Text;
            u.Apellido = apellidoTxt.Text;
            u.UserName = nomUser.Text;
            u.Password = pass.Text;
            u.PPic = perfil.Image;

            du.addUser(u);
            Console.WriteLine(du.getUsers()[0].UserName + "  " + du.getUsers()[0].Password);
            new popup("Usuario creado correctamente", popup.AlertType.check);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Console.WriteLine(edt);
            if (edt)
            {
                Edit();
            }
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
            user tem = new user();
            datosUser du = new datosUser();
            home h = new home();

            tem.Nombre = nombreTxt.Text;
            tem.Apellido = apellidoTxt.Text;
            tem.UserName = nomUser.Text;
            tem.Password = pass.Text;
            tem.PPic = perfil.Image;

            du.getUsers()[index] = tem;
            new popup("Cambios guardados correctamente", popup.AlertType.check);
           
        }
        
        
    }
}
