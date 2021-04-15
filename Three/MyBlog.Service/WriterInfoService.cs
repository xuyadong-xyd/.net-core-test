using MyBlog.IRepository;
using MyBlog.IService;
using MyblogModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public  class WriterInfoService:BaseService<WriterInfo>, IWriterInfoService
    {
        private readonly IWriterInfoRepository _WriterInfoRepository;
        public WriterInfoService(IWriterInfoRepository iWriterInfoRepository)
        {
            base._iBaseRepository = iWriterInfoRepository;
            _WriterInfoRepository = iWriterInfoRepository;
        }
    }
}
