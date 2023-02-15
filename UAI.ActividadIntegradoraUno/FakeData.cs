using UAI.ActividadIntegradoraUno.Models;
using UAI.ActividadIntegradoraUno.Negocio;

namespace UAI.ActividadIntegradoraUno
{
    public static class FakeData
    {
        private static Random _random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        private static List<Auto> _fakeAutos = new List<Auto>
        {
            new Auto(RandomString(10), RandomString(10), RandomString(10), RandomString(10), 200 ),
            new Auto(RandomString(10), RandomString(10), RandomString(10), RandomString(10), 200 ),
            new Auto(RandomString(10), RandomString(10), RandomString(10), RandomString(10), 200 ),
            new Auto(RandomString(10), RandomString(10), RandomString(10), RandomString(10), 200 ),
        };
        private static List<Persona> _fakePersonas = new List<Persona>
        {
            new Persona("4821302",RandomString(10), RandomString(10), _fakeAutos),
            new Persona(RandomString(10),RandomString(10), RandomString(10)),
            new Persona(RandomString(10),RandomString(10), RandomString(10)),
            new Persona(RandomString(10),RandomString(10), RandomString(10)),
            new Persona(RandomString(10),RandomString(10), RandomString(10)),
            new Persona(RandomString(10),RandomString(10), RandomString(10)),
        };

        public static void CargarDatosFake(IPersonaNegocio personaNegocio, IAutoNegocio autoNegocio)
        {
            foreach (var item in _fakePersonas)
            {
                personaNegocio.Agregar(item);
            }
            foreach (var item in _fakeAutos)
            {
                var auto = new Auto(item.Patente, item.Marca, item.Modelo, item.Anio, item.Precio, new Persona(_fakePersonas[0].Dni,
                    _fakePersonas[0].Nombre,
                    _fakePersonas[0].Apellido));
                autoNegocio.Agregar(auto);
            }
        }
    }
}
