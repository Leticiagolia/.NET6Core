using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // Repositorio generico, implementa los metodos pasandole una tabla
        //T - tabla generica
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null,bool tracked = true); // Devuelve un campo de la tabla T
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? includeProperties = null); // Devuelve todos los campos de la tabla T
        void Add(T entity); // Agregar a la tabla
        void Remove(T entity); // Borrar de la tabla
        void RemoveRange(IEnumerable<T> entity); // Borrar rango de campos de una tabla
    }
}
