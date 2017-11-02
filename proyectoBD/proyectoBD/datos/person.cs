using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace proyectoBD
{
    [Serializable]
    public class person
    {
        public string nombre, apellido, number, dir, correo;
        public Image photo;

        public person()
        {

        }

       /* public person(string nombre, string apellido, string number, string dir, string correo, Image photo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Number = number;
            this.Dir = dir;
            this.Correo = correo;
            this.Photo = photo;
        }*/

        public string Nombre
        {
            /*get { return nombre != null ? nombre : "NA"; }
            set { if (value != null)
                    nombre = value;
                  else
                    nombre = "NA";
                }*/
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido != null ? apellido : "NA"; }
            set {
                if (value != null)
                    apellido = value;
                else
                    apellido = "NA";
                }
        }

        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string Number
        {
            get { return number != null ? number : "NA"; }
            set
            {
                if (value != null)
                    number = value;
                else
                    number = "NA";
            }
        }

        public string Dir
        {
            get { return dir != null ? dir : "NA"; }
            set
            {
                if (value != null)
                    dir = value;
                else
                    dir = "NA";
            }
        }

        public string Correo
        {
            get { return correo != null ? correo : "NA"; }
            set
            {
                if (value != null)
                    correo = value;
                else
                    correo = "NA";
            }
        }
    }
}
