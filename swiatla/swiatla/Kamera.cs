using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK;

namespace swiatla
{
    public partial class Kamera : Form
    {
        public Kamera()
        {
            InitializeComponent();
        }

        private void Kamera_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            //e.Graphics.DrawLine(p, 0, 0, 40, 40); <-- test czy rysowanie dziala jak powinno
        }

        //metoda do sterowania programem
        private void Kamera_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    //obrot w lewo
                    break;
                case Keys.D:
                    //obrot w prawo
                    break;
                case Keys.Z:
                    //material rozpraszajacy (drewno)
                    break;
                case Keys.X:
                    //material pomiedzy (plastik)
                    break;
                case Keys.C:
                    //material odbijajacy (szklo)
                    break;

                case Keys.Escape:
                    //wyjscie z aplikacji
                    Application.Exit();
                    break;
            }
        }

    }
}
