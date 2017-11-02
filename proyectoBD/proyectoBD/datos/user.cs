using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace proyectoBD
{
    public class user
    {
        public string nombre, apellido, username, password;
        public Image pPic;

        public user()
        {

        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Image PPic
        {
            get { return pPic; }
            set { pPic = value; }
        }
    }
}
