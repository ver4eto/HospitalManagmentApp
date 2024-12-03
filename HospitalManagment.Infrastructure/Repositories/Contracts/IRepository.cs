using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment.Infrastructure.Repositories.Contracts
{
    public interface IRepository<TType, TId> 
    {
        Task<IEnumerable<TType>> GetAllAsync();

        IEnumerable<TType> GetAll();

         

        IQueryable<TType> GetAllAttcahed();

        Task<TType> GetByIdAsync(TId id);

        TType GetById(TId id);

        void Add(TType item);
        Task AddAsync(TType entity);

        bool Update(TType entity);
        Task <bool>UpdateAsync(TType entity);
        bool Delete(TId id);
        Task<bool> DeleteAsync(TId id);

        TType FirstOrDefault(Func<TType, bool> predicate);
        Task< TType> FirstOrDefaultAsync(Expression<Func<TType, bool>> predicate);
    }
}
