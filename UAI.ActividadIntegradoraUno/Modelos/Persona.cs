namespace UAI.ActividadIntegradoraUno.Models
{
    public class Persona
    {
        public Persona(string dni, 
            string nombre, 
            string apellido,
            List<Auto> autos = null)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            if (autos != null)
            {
                Autos = autos;
            } else
            {
                Autos = new List<Auto>();
            }            
        }

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Auto> Autos { get; set; }
        public List<Auto> Lista_de_Autos()
        {
            var autos = new List<Auto>();
            foreach (var item in Autos)
            {
                autos.Add(new Auto(
                    item.Patente,
                    item.Marca,
                    item.Modelo,
                    item.Anio,
                    item.Precio,
                    this
                ));
            }
            return autos;
        }

        public int Cantidad_de_Autos()
        {
            return Lista_de_Autos().Count;
        }

        public string NombreCompleto()
        {
            return $"{Apellido}, {Nombre}";
        }

        //~Persona()
        //{
        //    Autos = null;
        //    MessageBox.Show($"DNI {Dni}");
        //}
        

    }
}
