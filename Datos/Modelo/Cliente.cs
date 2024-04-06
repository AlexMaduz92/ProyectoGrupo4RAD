using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Codigo{ get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public GrupoDescuento GrupoDescuento { get; set; }
        public CondiccionPago CondicionPago { get; set; }
    }
}
