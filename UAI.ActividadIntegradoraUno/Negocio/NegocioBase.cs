namespace UAI.ActividadIntegradoraUno.Negocio
{
    public abstract class NegocioBase<T>
    {
        protected void Insertar<T>(List<T> lista, T entidad)
        {
            lista.Add(entidad);            
        }        
        protected T Borrar<T>(List<T> lista,  
            CriterioBusqueda<T> busqueda,
            T aBorrar)
        {
            var valorBuscado = Buscar(lista, busqueda, aBorrar);
            if (valorBuscado != null)
                lista.Remove(valorBuscado);
            return valorBuscado;
        }

        protected T Buscar<T>(List<T> lista, 
            CriterioBusqueda<T> busqueda,
            T aBuscar)
        {
            bool encontrado = false;
            int i = 0;
            T valorBuscado = default(T);
            while (!encontrado && i < lista.Count)
            {
                if (busqueda(aBuscar, lista[i]))
                {
                    encontrado = true;                    
                    valorBuscado = lista[i];
                }
                i++;
            }
            return valorBuscado;
        }

        public delegate bool CriterioBusqueda<T>(T entidad, T entidad2);
        protected abstract T Actualizar(T entidad);        
    }
}
