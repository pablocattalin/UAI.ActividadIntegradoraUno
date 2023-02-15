using UAI.ActividadIntegradoraUno.Models;

namespace UAI.ActividadIntegradoraUno.Negocio
{
    public class PersonaNegocio : NegocioBase<Persona>, IPersonaNegocio
    {
        List<Persona> _personas = new List<Persona>();
        private List<Persona> _aux;
        public PersonaNegocio()
        {            
        }

        public List<Persona> Agregar(Persona persona)
        {
            var personaBuscada = Actualizar(persona);
            if (personaBuscada == null)
            {
                Insertar(_personas, persona);
            }
            return ListarPersonas();
        }

        public void AsignarAuto(Persona current, Auto currentAuto)
        {
            var titular = Buscar(_personas, BuscarPorDni, current);
            currentAuto.Titular = titular;
            titular.Autos.Add(currentAuto);
        }

        public bool BuscarPorDni(Persona personaEliminar, Persona personaGuardado)
        {
            return personaEliminar.Dni == personaGuardado.Dni;
        }

        public void DesasignarAuto(Persona current, string patente)
        {
            var persona = Buscar(_personas, BuscarPorDni, current);
            Auto autoDesasignar = null;
            foreach (var item in persona.Autos)
            {
                if (item.Patente == patente)
                    autoDesasignar = item;
            }
            persona.Autos.Remove(autoDesasignar);
        }

        public List<Persona> Eliminar(Persona persona)
        {
            Borrar(_personas, BuscarPorDni, persona);
            return ListarPersonas();
        }

        public List<Auto> ListarAutosPorDuenio(string dni)
        {
            var autos = new List<Auto>();
            var persona = Buscar(_personas, BuscarPorDni, new Persona(dni, string.Empty, string.Empty));            
            if (persona != null)
            {
                foreach (var item in persona.Autos)
                {
                    autos.Add(new Auto(item.Patente,
                        item.Marca,
                        item.Modelo,
                        item.Anio,
                        item.Precio));
                }
            }
            return autos;
        }

        public List<Persona> ListarPersonas()
        {
            _aux = new List<Persona>();
            foreach (var item in _personas)
            {
                _aux.Add(new Persona(
                    item.Dni,
                    item.Nombre,
                    item.Apellido));
            }
            return _aux;
        }

        public List<Persona> Modificar(Persona Persona)
        {
            Actualizar(Persona);
            return ListarPersonas();
        }

        public Persona ObtenerPersona(Persona persona)
        {
            var personaBuscada = Buscar(_personas, BuscarPorDni, persona);
            return new Persona(personaBuscada.Dni, personaBuscada.Nombre, personaBuscada.Apellido, personaBuscada.Autos);
        }

        protected override Persona Actualizar(Persona personaModificar = null)
        {            
            var personaBuscado = Buscar(_personas, BuscarPorDni, personaModificar);
            if (personaBuscado != null)
            {
                personaBuscado.Nombre = personaModificar.Nombre;
                personaBuscado.Apellido = personaModificar.Apellido;                
            }
            return personaBuscado;
        }
    }
}