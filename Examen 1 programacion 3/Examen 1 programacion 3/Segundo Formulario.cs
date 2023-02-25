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
    public partial class Segundo_Formulario : Form
    {
        public Segundo_Formulario()
        {
            InitializeComponent();
        }

        double descuento;
        double subtotal;
        double precio;
        double total;

        public double Total(double total)
        {
            descuento = subtotal * 0.15;
            total = subtotal - descuento;
            return total;
        }
        public async Task<double> TotalAPagarAsync(double Descuento)
        {
            var resultado = await Task.Run(() =>
            {
                double descuento = 0.15;
                double subtotal, total, descuentoOtorgado;
                subtotal = Convert.ToDouble(txt_PrecioProducto.Text) * (Convert.ToDouble(txt_Cantidad.Text));
                descuentoOtorgado = subtotal * descuento;
                total = subtotal - descuentoOtorgado;
                return total;
            });
            return resultado;
        }
        public async Task<double> SubTotalAPagarAsync(double total, double cantidad)
        {
            double resultado = await Task.Run(() =>
            {
                subtotal = precio * cantidad;
                subtotal = Convert.ToDouble(txt_PrecioProducto.Text) * (Convert.ToDouble(txt_Cantidad.Text));
                return subtotal;
            });
            return resultado;
        }

        private async void btn_AgregarCalcular_Click(object sender, EventArgs e)
        {
            int subtotal;
            double descuento = 0.15;
            double descuentoOtorgado;

            SubtotalTextBox.Text = "L. " + Convert.ToString(await SubTotalAPagarAsync(Convert.ToInt16(txt_PrecioProducto.Text), Convert.ToInt32(txt_Cantidad.Text)));
            descuentoOtorgado = await SubTotalAPagarAsync(Convert.ToInt32(txt_PrecioProducto.Text), Convert.ToInt32(txt_Cantidad.Text)) * descuento;
            DescuentoTextBox.Text = "L. " + Convert.ToString(descuentoOtorgado);

            TotalPagarTextBox.Text = "L. " + Convert.ToString(await TotalAPagarAsync(Convert.ToInt32(txt_Cantidad.Text)));
        }
    }
}
