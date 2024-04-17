using Datos.Core;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DGrupoDescuento
    {

        UnitOfWork _unitOfWork;

        public DGrupoDescuento() { _unitOfWork = new UnitOfWork(); }
        public List<GrupoDescuento> Todaslosgruposdescuento()
        {

            return _unitOfWork.Repository<GrupoDescuento>().Consulta().ToList();
        }
    }
}
