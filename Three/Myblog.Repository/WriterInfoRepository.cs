using MyBlog.IRepository;
using MyblogModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Myblog.Repository
{
    public class WriterInfoRepository:BaseRepository<WriterInfo>, IWriterInfoRepository
    {
    }
}
