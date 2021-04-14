using MyBlog.IService;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MyBlog.IRepository;

namespace MyBlog.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        //从子类的构造函数中传入
        protected IBaseRepository<TEntity> _iBaseRepository;

        public virtual async Task<bool> CreateAsync(TEntity tentity)
        {
            return await _iBaseRepository.CreateAsync(tentity);
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            return await _iBaseRepository.DeleteAsync(id);
        }

        public virtual async Task<bool> EditAsync(TEntity tentity)
        {
            return await _iBaseRepository.EditAsync(tentity);
        }

        public virtual async Task<TEntity> FinedAsync(int id)
        {
            return await _iBaseRepository.FinedAsync(id);
        }

        public virtual async Task<List<TEntity>> QueryAsync()
        {
            return await _iBaseRepository.QueryAsync();
        }

        public  Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QueryAsync(int page, int size, RefAsync<int> total)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func, int page, int size, RefAsync<int> total)
        {
            throw new NotImplementedException();
        }
    }
}
