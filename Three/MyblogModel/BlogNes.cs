using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
namespace MyblogModel
{
    public class BlogNes : BaseId
    {
        /// <summary>
        /// nvarchar带中文的
        /// </summary>
        [SugarColumn(ColumnDataType ="nvarchar(30)")]
        public string Title { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        [SugarColumn(ColumnDataType ="text")]
        public string Content { get; set; }
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public int BrowseCount { get; set; }
        //点赞量
        public int LikeCount { get; set; }
        /// <summary>
        /// 类型Id
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 作者Id
        /// </summary>
        public int WriterId { get; set; }
        [SugarColumn(IsIgnore =true)]
        public Typeinfo TypeInfo { get; set; }
        [SugarColumn(IsIgnore = true)]
        public WriterInfo Writerinfo { get; set; }
    }
}
