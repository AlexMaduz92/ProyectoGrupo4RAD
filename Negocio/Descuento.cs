using Datos.Core;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Descuento
    {
        private readonly UnitOfWork _unitOfWork;

        public Descuento(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Datos.Modelo.GrupoDescuento ObtenerGrupoDescuentoPorId(int id)
        {
            return _unitOfWork.Repository<Datos.Modelo.GrupoDescuento>().ObtenerPorId(id);
        }

        public void GuardarGrupoDescuento(Datos.Modelo.GrupoDescuento grupoDescuento)
        {
            _unitOfWork.Repository<Datos.Modelo.GrupoDescuento>().Agregar(grupoDescuento);
            _unitOfWork.Guardar();
        }

        public void ModificarGrupoDescuento(Datos.Modelo.GrupoDescuento grupoDescuento)
        {
            _unitOfWork.Repository<Datos.Modelo.GrupoDescuento>().Editar(grupoDescuento);
            _unitOfWork.Guardar();
        }

        public void EliminarGrupoDescuento(int id)
        {
            var grupoDescuento = _unitOfWork.Repository<Datos.Modelo.GrupoDescuento>().ObtenerPorId(id);
            if (grupoDescuento != null)
            {
                grupoDescuento.Estado = false;
                _unitOfWork.Repository<Datos.Modelo.GrupoDescuento>().Editar(grupoDescuento);
                _unitOfWork.Guardar();
            }
        }
    }
}
