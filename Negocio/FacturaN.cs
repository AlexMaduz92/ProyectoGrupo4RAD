using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Base_de_Dato;
using Datos.Modelo;

namespace Negocio
{
    public class FacturaN
    {

        private readonly Exaconection _dbContext;

        public FacturaN()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarFactura(Factura Factura)
        {
            _dbContext.Facturas.Add(Factura);
            _dbContext.SaveChanges();

        }

        public void ModificarFactura(Factura factura)
        {
            var facturaExistente = _dbContext.Facturas.Find(factura.FacturaId);
            if (facturaExistente != null)
            {
                facturaExistente.ClienteId = factura.ClienteId;
                facturaExistente.PedidoId = factura.PedidoId;
                facturaExistente.FechaCreacion = factura.FechaCreacion;
                facturaExistente.FechaFactura = factura.FechaFactura;
                facturaExistente.Estado = factura.Estado;
                facturaExistente.Total = factura.Total;
                facturaExistente.Subtotal = factura.Subtotal;
                facturaExistente.Descuento = factura.Descuento;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarfACTURA(int FacturaId)
        {
            var factura = _dbContext.Pedidos.Find(FacturaId);
            if (factura != null)
            {
                _dbContext.Pedidos.Remove(factura);
                _dbContext.SaveChanges();
            }
        }

        public List<int> ObtenerIdFacturas()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Facturas.Select(c => c.FacturaId).ToList();
            }
        }

        public List<int> ObtenerIdClientes()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Clientes.Select(c => c.ClienteId).ToList();
            }
        }

        public List<int> ObtenerIdPedidos()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Pedidos.Select(c => c.PedidoId).ToList();
            }
        }

        public string ObtenerNombreClientePorId(int clienteId)
        {
            return _dbContext.Clientes.FirstOrDefault(c => c.ClienteId == clienteId)?.Nombres;
        }
    }
}
