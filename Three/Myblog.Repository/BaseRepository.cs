using MyBlog.IRepository;
using MyblogModel;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Myblog.Repository
{
    public class BaseRepository<Tentity> :SimpleClient<Tentity>,IBaseRepository<Tentity> where Tentity : class, new()
    {
        public BaseRepository(ISqlSugarClient context=null):base(context)
        {
            base.Context = DbScoped.Sugar;
            ///创建数据库
            base.Context.DbMaintenance.CreateDatabase();
            base.Context.CodeFirst.InitTables(
                typeof(BlogNes),
                 typeof(Typeinfo),
                  typeof(WriterInfo)
                );
        }
        public async Task<bool> CreateAsync(Tentity tentity)
        {
            return await base.InsertAsync(tentity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await base.DeleteByIdAsync(id);
        }

        public async Task<bool> EditAsync(Tentity tentity)
        {
            return await base.UpdateAsync(tentity);
        }
        /// <summary>
        /// 导航查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<Tentity> FinedAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        public async Task<List<Tentity>> QueryAsync()
        {
            return await base.GetListAsync();
        }

        public async Task<List<Tentity>> QueryAsync(Expression<Func<Tentity, bool>> func)
        {
            return await base.GetListAsync(func);
        }

        public async Task<List<Tentity>> QueryAsync(int page, int size, RefAsync<int> total)
        {
            return await base.Context.Queryable<Tentity>()
                 .ToPageListAsync(page, size, total);

        }

        public async Task<List<Tentity>> QueryAsync(Expression<Func<Tentity, bool>> func, int page, int size, RefAsync<int> total)
        {
            return await base.Context.Queryable<Tentity>()
                 .Where(func)
                 .ToPageListAsync(page, size, total);
        }
    }
}
