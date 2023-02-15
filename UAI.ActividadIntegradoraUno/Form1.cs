using System;
using System.ComponentModel;
using System.Data;
using System.Dynamic;
using System.Windows.Forms;
using UAI.ActividadIntegradoraUno.Forms;
using UAI.ActividadIntegradoraUno.Models;
using UAI.ActividadIntegradoraUno.Negocio;

namespace UAI.ActividadIntegradoraUno
{
    public partial class Form1 : Form
    {
        private IPersonaNegocio _personasNegocio;
        private IAutoNegocio _autosNegocio;
     
        public Form1()
        {
            _personasNegocio = new PersonaNegocio();
            _autosNegocio = new AutoNegocio();            
            InitializeComponent();
            FakeData.CargarDatosFake(_personasNegocio, _autosNegocio);
            MostrarData(dgvPersonas, _personasNegocio.ListarPersonas());
            MostrarData(dGvAutos,
                _autosNegocio.ListarAutos(),
                EsconderColumnasDgv,
                new List<string> { "Titular" });
            ListarDatosCompletosAuto();
        }

        public void AltaPersona(Persona persona)
        {
            _personasNegocio.Agregar(persona);
            MostrarData(dgvPersonas, _personasNegocio.ListarPersonas());
        }


        private void MostrarData<T>(DataGridView dgv, 
            T datos, 
            EsconderColumnas esconder = null, 
            List<string> columnas = null)
        {
            
            dgv.DataSource = null;
            dgv.DataSource = datos;
            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (esconder != null)
                esconder(dgv, columnas);
        }

        private void btnClickAgregarPersona(object sender, EventArgs e)
        {
            PersonaForm personaForm = new PersonaForm(this);
            personaForm.Show();            
        }

        private void btnClickModificarPersona(object sender, EventArgs e)
        {
            var current = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            if (current != null)
            {
                PersonaForm personaForm = new PersonaForm(this, true, current);
                personaForm.Show();
            }
        }

        public void EliminarPersona(Persona persona)
        {

            _autosNegocio.DesasignarTitular(_personasNegocio.ListarAutosPorDuenio(persona.Dni));
            _personasNegocio.Eliminar(persona);                        
            MostrarData(dgvPersonas, _personasNegocio.ListarPersonas());
            MostrarData(dGvAutos,
                _autosNegocio.ListarAutos(),
                EsconderColumnasDgv,
                new List<string> { "Titular" });
            ListarDatosCompletosAuto();
            dgvAutosPersona.DataSource = null;
        }

        private void btnClickAgregarAuto(object sender, EventArgs e)
        {
            AutoForm autoForm = new AutoForm(this);
            autoForm.Show();
        }

        private void btnClickModificarAuto(object sender, EventArgs e)
        {
            var current = (Auto)dGvAutos.CurrentRow.DataBoundItem;
            if (current != null)
            {
                AutoForm autoForm = new AutoForm(this, true, current);
                autoForm.Show();
            }
        }

        public void AltaAuto(Auto auto)
        {                        
            _autosNegocio.Agregar(auto);
            MostrarData(dGvAutos, 
                _autosNegocio.ListarAutos(), 
                EsconderColumnasDgv, 
                new List<string> { "Titular"});
            ListarDatosCompletosAuto();
        }

        public void EliminarAuto(Auto auto)
        {
            _autosNegocio.Eliminar(auto);
            MostrarData(dGvAutos,
                _autosNegocio.ListarAutos(),
                EsconderColumnasDgv,
                new List<string> { "Titular" });            
            ListarDatosCompletosAuto();
        }

        private void selectedPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            if (current != null)
            {                
                MostrarData(dgvAutosPersona,
                _personasNegocio.ListarAutosPorDuenio(current.Dni),
                EsconderColumnasDgv,
                new List<string> { "Titular" });
                var persona = _personasNegocio.ObtenerPersona(current);
                lblValuacionAutos.Text = $"Total de autos {persona.Cantidad_de_Autos()} - {EnumExtensions.GetDisplayName(ELabels.VALUACION)} " +
                    $"{_autosNegocio.TotalPrecioAutosPorDni(persona)} $";
            }
        }


        private void ListarDatosCompletosAuto()
        {
            DataTable dtable = new DataTable();
            dtable.Columns.Add("Marca", typeof(string));
            dtable.Columns.Add("Año", typeof(string));
            dtable.Columns.Add("Modelo", typeof(string));
            dtable.Columns.Add("Patente", typeof(string));
            dtable.Columns.Add("DNI", typeof(string));
            dtable.Columns.Add("Apellido, Nombre", typeof(string));
            foreach (var item in _autosNegocio.ListarAutos())
            {
                dtable.Rows.Add(
                    item.Marca,
                    item.Anio,
                    item.Modelo,
                    item.Patente,
                    item.Duenio() == null ? String.Empty : item.Duenio().Dni,
                    item.Duenio() == null ? String.Empty : item.Duenio().NombreCompleto()
                );
            }
            MostrarData<DataTable>(dgvTitularCompleto,
            dtable);
        }


        private delegate void EsconderColumnas(DataGridView dgv, List<string> columnas);

        private void EsconderColumnasDgv(DataGridView dgv, List<string> columnas)
        {
            foreach (var col in columnas)
            {
                dgv.Columns[col].Visible = false;
            }            
        }

        private Persona AsignarPersonaSeleccionada()
        {
            Persona persona = null;
            if (dgvPersonas.CurrentRow != null)
            {
                persona = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            }
            return persona;
        }

        private Auto AsignarAutoSeleccionada()
        {
            Auto auto = null;
            if (dGvAutos.CurrentRow != null)
            {
                auto = (Auto)dGvAutos.CurrentRow.DataBoundItem;
            }
            return auto;
        }

        private void btnAsignarAuto_Click(object sender, EventArgs e)
        {
            Persona current = AsignarPersonaSeleccionada();
            Auto currentAuto = AsignarAutoSeleccionada();
            if (current != null && currentAuto != null)
            {                
                if (currentAuto.Duenio() != null)
                {
                    MessageBox.Show($"El auto ya tiene un titular. DNI {currentAuto.Duenio().Dni}");
                } else
                {
                    _personasNegocio.AsignarAuto(current, currentAuto);
                    _autosNegocio.Modificar(currentAuto);
                    MostrarData(dgvAutosPersona,
                    _personasNegocio.ListarAutosPorDuenio(current.Dni),
                    EsconderColumnasDgv,
                    new List<string> { "Titular" });
                    ListarDatosCompletosAuto();
                }                
            }
        }

        private void btnDesasignarTitular_Click(object sender, EventArgs e)
        {
            Persona current = AsignarPersonaSeleccionada();
            Auto currentAuto = AsignarAutoSeleccionada();
            if (current != null && currentAuto != null)
            {
                if (currentAuto.Duenio() != null && current.Dni == currentAuto.Duenio().Dni)
                {                    
                    _personasNegocio.DesasignarAuto(current, currentAuto.Patente);
                    _autosNegocio.DesasignarTitular(currentAuto);
                    MostrarData(dGvAutos,
                    _autosNegocio.ListarAutos(),
                    EsconderColumnasDgv,
                    new List<string> { "Titular" });
                    MostrarData(dgvAutosPersona,
                    _personasNegocio.ListarAutosPorDuenio(current.Dni),
                    EsconderColumnasDgv,
                    new List<string> { "Titular" });
                    ListarDatosCompletosAuto();
                }
                else
                {
                    MessageBox.Show($"El auto no tiene al titular seleccionado.");
                }
            }
        }
    }
}