using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ENE.Entities
{
    public class Trabajador
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string ValorHora { get; set; }
        public string ValorHoraExtra { get; set; }
        public string SueldoLiquido { get; set; }
    }
}
