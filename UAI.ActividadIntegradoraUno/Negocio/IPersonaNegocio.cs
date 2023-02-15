using UAI.ActividadIntegradoraUno.Models;

namespace UAI.ActividadIntegradoraUno.Negocio
{
    public interface IPersonaNegocio
    {
        List<Persona> Agregar(Persona auto);
        List<Persona> Eliminar(Persona auto);
        List<Persona> Modificar(Persona auto);
        List<Persona> ListarPersonas();
        List<Auto> ListarAutosPorDuenio(string dni);
        Persona ObtenerPersona(Persona persona);
        void AsignarAuto(Persona current, Auto currentAuto);
        void DesasignarAuto(Persona current, string patente);
    }
}
