﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class GrupoDescuento
    {
        public int GrupoDescuentoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public decimal Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
