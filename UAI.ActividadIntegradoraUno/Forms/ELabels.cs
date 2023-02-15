using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;

namespace UAI.ActividadIntegradoraUno.Forms
{
    public enum ELabels
    {
        [Display(Name ="CANCELAR")]
        CANCELAR,
        [Display(Name ="ELIMINAR")]
        ELIMINAR,
        [Display(Name = "Valuacion total de autos")]
        VALUACION,
    }

    public static class EnumExtensions
    {

        /// <summary>
        ///     A generic extension method that aids in reflecting 
        ///     and retrieving any attribute that is applied to an `Enum`.
        /// </summary>
        public static string GetDisplayName(this Enum enumValue)                
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}
