using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.Base_de_Dato;

namespace Negocio
{
    public class CondicionesPago
    {
        private readonly Exaconection _dbContext;

        public CondicionesPago()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarCondicionPago(Datos.Modelo.CondiccionPago condicionPago)
        {
            _dbContext.CondicionPagos.Add(condicionPago);
            _dbContext.SaveChanges();
        }

        public void ModificarCondicionPago(Datos.Modelo.CondiccionPago condicionPago)
        {
            var condicionPagoExistente = _dbContext.CondicionPagos.Find(condicionPago.CondicionPagoId);
            if (condicionPagoExistente != null)
            {
                condicionPagoExistente.Codigo = condicionPago.Codigo;
                condicionPagoExistente.Descripcion = condicionPago.Descripcion;
                condicionPagoExistente.Dias = condicionPago.Dias;
                condicionPagoExistente.Estado = condicionPago.Estado;
                condicionPagoExistente.FechaCreacion = condicionPago.FechaCreacion;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarCondicionPago(int condicionPagoId)
        {
            var condicionPago = _dbContext.CondicionPagos.Find(condicionPagoId);
            if (condicionPago != null)
            {
                condicionPago.Estado = false;
                _dbContext.SaveChanges();
            }
        }


        public Datos.Modelo.CondiccionPago ObtenerCondicionPagoPorId(int condicionPagoId)
        {
            return _dbContext.CondicionPagos.FirstOrDefault(c => c.CondicionPagoId == condicionPagoId);
        }

    }
}
