using Datos.Base_de_Dato;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class NUMedidas
    {

        private readonly Exaconection _dbContext;

        public NUMedidas()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarMedida(UnidadMedida medida)
        {
            _dbContext.UnidadMedidas.Add(medida);
            _dbContext.SaveChanges();
        }

        public void ModificarMedida(UnidadMedida medida)
        {
            var medidaExistente = _dbContext.UnidadMedidas.Find(medida.UnidadMedidaId);
            if (medidaExistente != null)
            {
                medidaExistente.Codigo = medida.Codigo;
                medidaExistente.Descripcion = medida.Descripcion;
                medidaExistente.Estado = medida.Estado;
                medidaExistente.FechaCreacion = medida.FechaCreacion;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarMedida(int medidaId)
        {
            var medida = _dbContext.UnidadMedidas.Find(medidaId);
            if (medida != null)
            {
                medida.Estado = false;
                _dbContext.SaveChanges();
            }
        }

        public UnidadMedida ObtenerMedidaPorId(int medidaId)
        {
            return _dbContext.UnidadMedidas.FirstOrDefault(m => m.UnidadMedidaId == medidaId);
        }
    }
}
