using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.IRepository
{
   public interface IBaseRepository<Tentity> where Tentity:class,new()
    {
        Task<bool> CreateAsync(Tentity tentity);
        Task<bool> DeleteAsync(int id);
        Task<bool> EditAsync(Tentity tentity);
        Task<Tentity> FinedAsync(int id);
        /// <summary>
        /// 查询全部数据
        /// </summary>
        /// <returns></returns>
        Task<List<Tentity>> QueryAsync();
        /// <summary>
        /// 自定义查询条件
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        Task<List<Tentity>> QueryAsync(Expression<Func<Tentity,bool>> func);
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        Task<List<Tentity>> QueryAsync(int page,int size,RefAsync<int> total);
        /// <summary>
        /// 自定义分页查询
        /// </summary>
        /// <param name="func"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        Task<List<Tentity>> QueryAsync(Expression<Func<Tentity, bool>> func, int page, int size, RefAsync<int> total);

    }
}
