﻿using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
namespace MyblogModel
{
  public  class WriterInfo
    {
        [SugarColumn(ColumnDataType = ("nvarchar(12)"))]
        public string Name { get; set; }
        [SugarColumn(ColumnDataType = ("nvarchar(16)"))]
        public string UserName { get; set; }
        [SugarColumn(ColumnDataType = ("nvarchar(64)"))]
        public string UserPwd { get; set; }
    }
}
