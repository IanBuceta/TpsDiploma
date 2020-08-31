using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCrearFordFiesta_Click(object sender, EventArgs e)
        {
            Auto auto;
            if (radioButton3Puertas.Checked)
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFordFiestaTresPuertas());
            }
            else
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFordFiestaCincoPuertas());
            }
            listBoxAuto.Items.Add(auto.ToString());
        }

        private void buttonCrearFordFocus_Click(object sender, EventArgs e)
        {
            Auto auto;
            if (radioButton3Puertas.Checked)
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFordFocusTresPuertas());
            }
            else
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFordFocusCincoPuertas());
            }
            listBoxAuto.Items.Add(auto.ToString());
        }

        private void buttonCrearFiatPalio_Click(object sender, EventArgs e)
        {
            Auto auto;
            if (radioButton3Puertas.Checked)
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFiatPalioTresPuertas());
            }
            else
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFiatPalioCincoPuertas());
            }
            listBoxAuto.Items.Add(auto.ToString());
        }

        private void buttonCrearFiatSiena_Click(object sender, EventArgs e)
        {
            Auto auto;
            if (radioButton3Puertas.Checked)
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFiatSienaTresPuertas());
            }
            else
            {
                auto = Fabricante.ConstruirAuto(new ConstructorFiatSienaCincoPuertas());
            }
            listBoxAuto.Items.Add(auto.ToString());
        }
    }
}
