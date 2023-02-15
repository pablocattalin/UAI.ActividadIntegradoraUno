using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAI.ActividadIntegradoraUno.Models;
using UAI.ActividadIntegradoraUno.Negocio;

namespace UAI.ActividadIntegradoraUno.Forms
{
    public partial class PersonaForm : Form
    {        
        private Form1 _formPrincipal;
        public PersonaForm(Form1 form1, bool edicion = false, Persona persona = null)
        {
            InitializeComponent();            
            if (edicion)
            {
                CargarInformacionFormulario(persona);
            }
            _formPrincipal = form1;
        }

        private void CargarInformacionFormulario(Persona persona)
        {
            txtDni.Text = persona.Dni;
            txtDni.Enabled = false;
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            btnEliminarPersona.Text = EnumExtensions.GetDisplayName(ELabels.ELIMINAR);
        }

        private void btnGuardar(object sender, EventArgs e)
        {            
            _formPrincipal.AltaPersona(new Persona(
                txtDni.Text,
                txtNombre.Text,
                txtApellido.Text
            ));
            this.Close();
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            if (btnEliminarPersona.Text == EnumExtensions.GetDisplayName(ELabels.ELIMINAR))
            {
                _formPrincipal.EliminarPersona(new Persona(
                    txtDni.Text,
                    txtNombre.Text,
                    txtApellido.Text                   
                ));
            }
            this.Close();
        }
    }
}
