using UAI.ActividadIntegradoraUno.Models;

namespace UAI.ActividadIntegradoraUno.Negocio
{
    public interface IAutoNegocio
    {
        List<Auto> Agregar(Auto auto);
        List<Auto> Eliminar(Auto auto);
        List<Auto> Modificar(Auto auto);
        List<Auto> ListarAutos();
        void DesasignarTitular(List<Auto> autos);
        void DesasignarTitular(Auto auto);
        decimal TotalPrecioAutosPorDni(Persona persona);
    }
}
