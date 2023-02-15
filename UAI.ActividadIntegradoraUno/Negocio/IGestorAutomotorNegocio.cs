namespace UAI.ActividadIntegradoraUno.Negocio
{
    public interface IGestorAutomotorNegocio
    {
        T Agregar<T>(List<T> lista, T entidad);
        void Borrar<T>(List<T> lista, T entidad);
        void Modificar<T>(List<T> lista, Func<T, bool> criterio);

    }
}
