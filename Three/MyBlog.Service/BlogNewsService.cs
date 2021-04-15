using MyBlog.IRepository;
using MyBlog.IService;
using MyblogModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public class BlogNewsService : BaseService<BlogNes>,IBlogMewsService
    {
        private readonly IBlogNewsRepository _iBlogNesRepository;
        public BlogNewsService(IBlogNewsRepository blogNewsRepository)
        {
            base._iBaseRepository = blogNewsRepository;
            _iBlogNesRepository = blogNewsRepository;
        }
        
    }
}
