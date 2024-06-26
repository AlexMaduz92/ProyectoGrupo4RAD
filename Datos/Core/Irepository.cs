﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Datos.Core
{
    public interface Irepository<T> where T : class
    {
        T ObtenerPorId(int id);
        IEnumerable<T> ObtenerTodos();
        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);
        void Agregar(T entidad);
        void Editar(T entidad);
        void Eliminar(T entidad);
        IQueryable<T> Consulta();
    }
}
