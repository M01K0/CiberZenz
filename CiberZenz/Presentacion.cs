using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiberZenz
{
    public partial class Presentacion : Form
    {
        Boolean Opacidad = false;
        public Presentacion()
        {
            InitializeComponent();
            Tempo_Inicio.Start();
        }

        private void Tempo_Inicio_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                Opacidad = true;

            }

            if (Opacidad)
            {
                Tempo_Inicio.Stop();
                Tempo_Fin.Start();
                Tempo_Fin.Interval = 2000;
            }
            else
            {
                this.Opacity += .10;
            }
        }

        private void Tempo_Fin_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= .50)
            {
                new InicioSesion().Show();
                this.Hide();
                Tempo_Fin.Stop();
            }
            else
            {
                Tempo_Fin.Interval = 100;
                this.Opacity -= .15;
            }
        }
    }
}