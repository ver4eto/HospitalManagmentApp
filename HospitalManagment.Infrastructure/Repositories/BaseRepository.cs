using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagmentApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HospitalManagment.Infrastructure.Repositories
{
    public class BaseRepository<TType, TId> : IRepository<TType, TId> where TType : class
    {
        private readonly HMDbContext dbContext;
        private readonly DbSet<TType> dbSet;

        public BaseRepository(HMDbContext context)
        {
            this.dbContext = context;
            this.dbSet = this.dbContext.Set<TType>();
        }

        public void Add(TType item)
        {
            this.dbSet.Add(item);
            this.dbContext.SaveChanges();
        }

        public async Task AddAsync(TType entity)
        {
            await this.dbSet.AddAsync(entity);
            await this.dbContext.SaveChangesAsync();

        }

        public bool Delete(TId id)
        {
            TType entity=this.GetById(id);
            if(entity==null) return false;

            this.dbSet.Remove(entity);
            this.dbContext.SaveChanges();

            return true;
        }

        public async Task<bool> DeleteAsync(TId id)
        {
            TType entity = await this.GetByIdAsync(id);
            if (entity == null)
            {
                return false;
            }

           this.dbSet.Remove(entity);
            await this.dbContext.SaveChangesAsync();

            return true;

        }
        public IEnumerable<TType> GetAll()
        {
            return this.dbSet.ToArray();
        }

        public async Task<IEnumerable<TType>> GetAllAsync()
        {
            return await this.dbSet.ToArrayAsync();

        }

        public IQueryable<TType> GetAllAttcahed()
        {
            return this.dbSet.AsQueryable();
        }

        public TType GetById(TId id)
        {
            TType entity = this.dbSet
                 .Find(id);

            return entity;
        }

        public async Task<TType> GetByIdAsync(TId id)
        {
            TType entity = await this.dbSet.FindAsync(id);
            return entity;

        }

       
        public async Task<bool> UpdateAsync(TType entity)
        {
            try
            {
                this.dbSet.Attach(entity);
                this.dbContext.Entry(entity).State = EntityState.Modified;
               await this.dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public bool Update(TType entity)
        {
            try
            {
                this.dbSet.Attach(entity);
                this.dbContext.Entry(entity).State = EntityState.Modified;
                this.dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

               return false;
            }
           
        }

        public TType FirstOrDefault(Func<TType, bool> predicate)
        {
            TType entity = this.dbSet
                .FirstOrDefault(predicate);

            return entity;
        }

        public async Task<TType> FirstOrDefaultAsync(Expression<Func<TType, bool>> predicate)
        {
            TType entity = await this.dbSet
                .FirstOrDefaultAsync(predicate);

            return entity;
        }

       
    }
}
