using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAI.ActividadIntegradoraUno.Models;

namespace UAI.ActividadIntegradoraUno.Forms
{
    public partial class AutoForm : Form
    {        
        

        private Form1 _formPrincipal;
        public AutoForm(Form1 form1, bool edicion = false, Auto Auto = null)
        {
            InitializeComponent();
            if (edicion)
            {
                CargarInformacionFormulario(Auto);
            }
            _formPrincipal = form1;
        }

        private void CargarInformacionFormulario(Auto auto)
        {
            txtPatente.Text = auto.Patente;
            txtPatente.Enabled = false;
            txtMarca.Text = auto.Marca;
            txtModelo.Text = auto.Modelo;
            txtAnio.Text = auto.Anio;
            txtPrecio.Text = auto.Precio.ToString();
            btnEliminarAuto.Text = EnumExtensions.GetDisplayName(ELabels.ELIMINAR);
        }

        private void btnGuardarAuto_Click(object sender, EventArgs e)
        {
            bool anioValido = int.TryParse(txtAnio.Text, out int t) && int.Parse(txtAnio.Text) > 1900 && int.Parse(txtAnio.Text) <= DateTime.Now.Year;
            bool precioValido = Decimal.TryParse(txtPrecio.Text, out decimal d);
            if (!anioValido)
            {
                MessageBox.Show("Ingresa un precio valido");
            }
            if (!precioValido)
            {
                MessageBox.Show($"Los anios permitidos son desde 1900 a {DateTime.Now.Year}");
            }
            if (precioValido && anioValido)
            {
                _formPrincipal.AltaAuto(new Auto(
                    txtPatente.Text,
                    txtMarca.Text,
                    txtModelo.Text,
                    txtAnio.Text,
                    decimal.Parse(txtPrecio.Text)
                ));
                this.Close();
            }
        }
        

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            if (btnEliminarAuto.Text == EnumExtensions.GetDisplayName(ELabels.ELIMINAR))
            {
                _formPrincipal.EliminarAuto(new Auto(
                    txtPatente.Text,
                    txtMarca.Text,
                    txtModelo.Text,
                    txtAnio.Text,
                    decimal.Parse(txtPrecio.Text)
                ));
            }
            this.Close();
        }
    }
}
