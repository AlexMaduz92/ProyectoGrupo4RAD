using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Base_de_Dato;
using Datos.Modelo;
using Negocio;


namespace Negocio
{
    public class DetalleFactura
    {
        public readonly Exaconection _dbContext;

        public DetalleFactura()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarFacturaDetalle(FacturaDetalle facturaDetalle)
        {
            _dbContext.FacturaDetalles.Add(facturaDetalle);
            _dbContext.SaveChanges();
        }

        public void ModificarFacturaDetalle(FacturaDetalle facturaDetalle)
        {
            var facturaDetalleExistente = _dbContext.FacturaDetalles.Find(facturaDetalle.FacturaDetalleId);
            if (facturaDetalle != null)
            {
                facturaDetalleExistente.FacturaId = facturaDetalle.FacturaId;
                facturaDetalleExistente.FechaCreacion = facturaDetalle.FechaCreacion;
                facturaDetalleExistente.ProductoId = facturaDetalle.ProductoId;
                facturaDetalleExistente.Precio = facturaDetalle.Precio;
                facturaDetalleExistente.Total = facturaDetalle.Total;
                facturaDetalleExistente.SubTotal = facturaDetalle.SubTotal;
                facturaDetalleExistente.Descuento = facturaDetalle.Descuento;
                facturaDetalleExistente.Estado=facturaDetalle.Estado;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarFacturaDetalle(int FacturaDetalleId)
        {
            var fdetalle= _dbContext.FacturaDetalles.Find(FacturaDetalleId);
            if (fdetalle != null)
            {
                fdetalle.Estado = 0;
                _dbContext.SaveChanges();
            }
        }

        public FacturaDetalle ObtenerFacturaPorId(int FdetalleId)
        {
            using (var context = new Exaconection())
            {
                return context.FacturaDetalles.FirstOrDefault(p => p.FacturaDetalleId == FdetalleId);
            }
        }
    }
}
