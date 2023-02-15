using UAI.ActividadIntegradoraUno.Models;

namespace UAI.ActividadIntegradoraUno.Negocio
{
    public class AutoNegocio : NegocioBase<Auto>, IAutoNegocio
    {
        private List<Auto> _autos;
        private List<Auto> _aux;
        public AutoNegocio()
        {
            _autos = new List<Auto>();
        }

        public List<Auto> Agregar(Auto auto)
        {
            var autoBuscada = Actualizar(auto);
            if (autoBuscada == null)
            {
                Insertar(_autos, auto);
            }                        
            return ListarAutos();
        }


        public bool BuscarPorPatente(Auto autoEliminar, Auto autoGuardado)
        {
            return autoEliminar.Patente == autoGuardado.Patente;
        }

        public void DesasignarTitular(List<Auto> autos)
        {
            foreach (var item in autos)
            {
                DesasignarTitular(item);
            }
        }

        public void DesasignarTitular(Auto autoBuscar)
        {
            autoBuscar.Titular = null;
            Modificar(autoBuscar);
        }

        public List<Auto> Eliminar(Auto auto)
        {
            Borrar(_autos, BuscarPorPatente, auto);
            return ListarAutos();
        }

        public List<Auto> ListarAutos()
        {
            _aux = new List<Auto>();
            foreach (var item in _autos)
            {
                _aux.Add(new Auto(
                    item.Patente,
                    item.Marca,
                    item.Modelo,
                    item.Anio,
                    item.Precio,
                    item.Titular));
            }
            return _aux;
        }

        public List<Auto> Modificar(Auto auto)
        {
            Actualizar(auto);
            return ListarAutos();
        }

        public decimal TotalPrecioAutosPorDni(Persona persona)
        {
            decimal total = 0;
            foreach (var item in persona.Autos)
            {
                total += item.Precio;
            }
            return total;
        }

        protected override Auto Actualizar(Auto autoModificar)
        {
            var autoBuscado = Buscar(_autos, BuscarPorPatente, autoModificar);
            if (autoBuscado != null)
            {
                autoBuscado.Anio = autoModificar.Anio;
                autoBuscado.Titular = autoModificar.Titular;
                autoBuscado.Modelo = autoModificar.Modelo;
                autoBuscado.Precio = autoModificar.Precio;
                autoBuscado.Marca = autoModificar.Marca;
            }
            return autoBuscado;
        }
    }
}
