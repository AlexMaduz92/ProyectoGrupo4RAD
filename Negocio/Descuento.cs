using Datos.Base_de_Dato;
using Datos.Modelo;
using System;
using System.Linq;

namespace Negocio
{
    public class Descuento
    {
        private readonly Exaconection _dbContext;

        public Descuento()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarDescuento(GrupoDescuento descuento)
        {
            _dbContext.GrupoDescuentos.Add(descuento);
            _dbContext.SaveChanges();
        }

        public void ModificarDescuento(GrupoDescuento descuento)
        {
            var descuentoExistente = _dbContext.GrupoDescuentos.Find(descuento.GrupoDescuentoId);
            if (descuentoExistente != null)
            {
                descuentoExistente.Codigo = descuento.Codigo;
                descuentoExistente.Descripcion = descuento.Descripcion;
                descuentoExistente.Porcentaje = descuento.Porcentaje;
                descuentoExistente.Estado = descuento.Estado;
                descuentoExistente.FechaCreacion = descuento.FechaCreacion;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarDescuento(int descuentoId)
        {
            var descuento = _dbContext.GrupoDescuentos.Find(descuentoId);
            if (descuento != null)
            {
                descuento.Estado = false;
                _dbContext.SaveChanges();
            }
        }

        public GrupoDescuento ObtenerDescuentoPorId(int descuentoId)
        {
            return _dbContext.GrupoDescuentos.FirstOrDefault(d => d.GrupoDescuentoId == descuentoId);
        }
    }
}
