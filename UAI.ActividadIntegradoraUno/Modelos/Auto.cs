namespace UAI.ActividadIntegradoraUno.Models
{
    public class Auto
    {        
        public Auto(string patente,
                    string marca,
                    string modelo,
                    string anio,
                    decimal precio,
                    Persona titular = null)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Titular = titular;    
        }

        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public decimal Precio { get; set; }
        public Persona Titular { get; set; }
        public Persona Duenio() 
        {
            return Titular;
        }

        //~Auto()
        //{
        //    MessageBox.Show($"Patente: {Patente}");
        //}

    }
}
