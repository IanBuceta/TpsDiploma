using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        MotoScooter motoScooter;
        MotoEnduro motoEnduro;
        MotoPistero motoPistero;
        public Form1()
        {
            InitializeComponent();
            motoScooter = new MotoScooter();
            motoEnduro = new MotoEnduro();
            motoPistero = new MotoPistero();
        }
        private void CrearMoto(PrototipoMoto moto)
        {
            listBoxMoto.Items.Add(moto.ToString());
        }

        private void buttonCrearScooter_Click(object sender, EventArgs e)
        {
            CrearMoto(motoScooter.Clone() as PrototipoMoto);
        }


        private void buttonCrearEnduro_Click(object sender, EventArgs e)
        {
            CrearMoto(motoEnduro.Clone() as PrototipoMoto);
        }

        private void buttonCrearPistero_Click(object sender, EventArgs e)
        {
            CrearMoto(motoPistero.Clone() as PrototipoMoto);
        }
    }
}
