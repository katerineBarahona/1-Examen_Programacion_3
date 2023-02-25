using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1_programacion_3
{
    public partial class Tercer_Formulario : Form
    {
        public Tercer_Formulario()
        {
            InitializeComponent();

        }
        int numero;
        private int Numero(int numero)
        {
            for (numero = 1; numero <= 100; numero++)
            {
                ValoresListBox.Items.Add(numero);
                if (numero % 3 == 0)
                {

                    ValoresListBox.Items.Add(" Katerine Pamela  ");
                }
                if (numero % 5 == 0)
                {
                    ValoresListBox.Items.Add(" Barahona Cerrato");

                }
                else if (numero % 3 == 0 && numero % 5 == 0)
                {
                    ValoresListBox.Items.Add(" Katerine Pamela Barahona Cerrato ");
                }
            }
            return numero;
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Numero(numero);
        }
    }
}
