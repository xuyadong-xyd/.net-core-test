using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
namespace MyblogModel
{
   public class Typeinfo:BaseId
    {
        [SugarColumn(ColumnDataType =("nvarchar"))]
        public string Name { get; set; }
    }
}
