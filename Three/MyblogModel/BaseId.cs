using System;
using SqlSugar;
namespace MyblogModel
{
    public class BaseId
    {
        [SugarColumn(IsIdentity =true,IsPrimaryKey =true)]
        public int Id { get; set; }
    }
}
