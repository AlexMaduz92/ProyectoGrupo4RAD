using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FacturaDetalle
    {
        public readonly Exaconection _dbContext;

        public FacturaDetalle()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarFacturaDetalle(FacturaDetalle facturaDetalle)
        {
            _dbContext.Pedidos.Add(facturaDetalle);
            _dbContext.SaveChanges();
        }

        public void ModificarFacturaDetalle(FacturaDetalle facturaDetalle)
        {
            var facturaDetalleExistente = _dbContext.FacturaDetalles.Find(facturaDetalleExistente.FacturaDetalleId);
            if (facturaDetalle != null)
            {
                facturaDetalleExistente.FacturaId = facturaDetalle.facturaId;
                facturaDetalleExistente.FechaCreacion = facturaDetalle.FechaCreacion;
                facturaDetalleExistente.ProductoId = facturaDetalle.ProductoId;
                facturaDetalleExistente.Precio = facturaDetalle.Precio;
                facturaDetalleExistente.Total = facturaDetalle.Total;
                facturaDetalleExistente.SubTotal = facturaDetalle.Subtotal;
                facturaDetalleExistente.Descuento = facturaDetalle.Descuento;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarFacturaDetalle(int FacturaDetalleId)
        {
            var facturaDetalle = _dbContext.FacturaDetalles.Find(FacturaDetalleId);
            if (facturaDetalle != null)
            {
                _dbContext.Pedidos.Remove(facturaDetalle);
                _dbContext.SaveChanges();
            }
        }

        public Pedido ObtenerFacturaPorId(int FacturaId)
        {
            using (var context = new Exaconection())
            {
                return context.FacturaDetalles.FirstOrDefault(p => p.FacturaDetalleId == facturaDetalleId);
            }
        }
    }
}
