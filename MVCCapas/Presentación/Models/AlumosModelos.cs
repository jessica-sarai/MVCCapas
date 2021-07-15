using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentación.Models
{
    public class AlumosModelos
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} es incorrecto")]
        public string nombre { get; set; }
        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} es incorrecto")]
        public string primerApellido { get; set; }
        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} es incorrecto")]
        public string segundoApellido { get; set; }

        [DataType(DataType.Text)]
        public string correo { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(10, MinimumLength =10, ErrorMessage = "El rango debe de ser {1} digitos")]
        public string telefono { get; set; }

        [Range(typeof(DateTime),"1995-01-01","2021-12-31", ErrorMessage ="El rango de fecha es incorrecto")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime fechaNacimiento { get; set; }

        [RegularExpression("^([A-Z&]|[a-z&]{1})([AEIOU]|[aeiou]{1})([A-Z&]|[a-z&]{1})([A-Z&]|[a-z&]{1})([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([HM]|[hm]{1})([AS|as|BC|bc|BS|bs|CC|cc|CS|cs|CH|ch|CL|cl|CM|cm|DF|df|DG|dg|GT|gt|GR|gr|HG|hg|JC|jc|MC|mc|MN|mn|MS|ms|NT|nt|NL|nl|OC|oc|PL|pl|QT|qt|QR|qr|SP|sp|SL|sl|SR|sr|TC|tc|TS|ts|TL|tl|VZ|vz|YN|yn|ZS|zs|NE|ne]{2})([^A|a|E|e|I|i|O|o|U|u]{1})([^A|a|E|e|I|i|O|o|U|u]{1})([^A|a|E|e|I|i|O|o|U|u]{1})([0-9]{2})", ErrorMessage = "El {0} no tiene el formato correcto")]
        public string curp { get; set; }

        public int idEstadoOrigen { get; set; }
        public short idEstatus { get; set; }
    }
}