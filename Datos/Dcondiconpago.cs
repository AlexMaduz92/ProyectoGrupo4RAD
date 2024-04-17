using Datos.Core;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dcondiconpago
    {
        UnitOfWork _unitOfWork;

        public Dcondiconpago() { _unitOfWork = new UnitOfWork(); }
        public List<CondiccionPago> TodasLasClasificaciones()
        {
           
            return _unitOfWork.Repository<CondiccionPago>().Consulta().ToList();
        }
    }
}
