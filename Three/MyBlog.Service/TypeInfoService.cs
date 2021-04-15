using MyBlog.IRepository;
using MyblogModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public  class TypeInfoService:BaseService<Typeinfo>, ITypeInfoService
    {
        private readonly ITypeInfoRepository _ibtypeInfoRepository;
        public TypeInfoService(ITypeInfoRepository iTypeInfoRepository)
        {
            base._iBaseRepository = iTypeInfoRepository;
            _ibtypeInfoRepository = iTypeInfoRepository;
        }

    }
}
