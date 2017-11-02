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
    public partial class viewCarga : Form
    {
        List<Color> color = new List<Color>();
        List<string> txt = new List<string>();
        int pos = 0;
        bool c = false;
        public viewCarga(type t)
        {
            InitializeComponent();
            
            color.Add(Color.FromArgb(104, 33, 122));
            color.Add(Color.FromArgb(42, 88, 173));
            color.Add(Color.FromArgb(255, 140, 0));
            color.Add(Color.FromArgb(213, 105, 0));

            progress.ProgressColor = color[pos];

            switch (t)
            {
                case type.inicio:
                    txt.Add("Iniciando");
                    txt.Add("Iniciando .");
                    txt.Add("Iniciando . .");
                    txt.Add("Iniciando . . .");
                    break;

                case type.cerrar:
                    txt.Add("Cerrando");
                    txt.Add("Cerrando .");
                    txt.Add("Cerrando . .");
                    txt.Add("Cerrando . . .");

                    c = true;

                    datosUser du = new datosUser();
                    du.saveBackup();

                    break;
            }

            this.Show();
        }

        int dir = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progress.Value == 90)
            {
                dir -=1;
                progress.animationIterval = 4;
                cambioColor();
            }else if (progress.Value == 10)
            {
                dir +=1;
                progress.animationIterval = 2;
                cambioColor();
            }

            progress.Value += dir;
        }

        void cambioColor()
        {
            bunifuColorTransition1.Color1 = color[pos];

            if (pos < color.Count - 1)
                pos++;
            else
                pos = 0;

            bunifuColorTransition1.Color2 = color[pos];
            colorT.Start();
        }

        private void colorT_Tick(object sender, EventArgs e)
        {
            if (bunifuColorTransition1.ProgessValue < 100)
            {
                bunifuColorTransition1.ProgessValue++;
                progress.ProgressColor = bunifuColorTransition1.Value;
            }
            else
            {
                bunifuColorTransition1.ProgessValue = 0;
                progress.ProgressColor = bunifuColorTransition1.Value;
            }
                
        }

        int i = 0;
        private void texto_Tick(object sender, EventArgs e)
        {
            label.Text = txt[i];

            if (i < txt.Count - 1)
                i++;
            else
                i=0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (c)
            {
                System.Environment.Exit(0);
            }
            else
            {
                home h = new home();
                login l = new login();
                datosUser du = new datosUser();
                int i = l.index;
                l.Dispose();

                h.Show();
                this.Close();
            }
            
        }

        public enum type
        {
            inicio, cerrar
        }
    }
}
