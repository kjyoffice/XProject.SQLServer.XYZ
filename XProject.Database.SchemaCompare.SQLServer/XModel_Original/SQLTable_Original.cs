﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace XProject.Database.SchemaCompare.SQLServer.XModel_Original
{
    public class SQLTable_Original
    {
        public string TABLE_NAME { get; private set; }

        // ---------------------------------------------------

        public SQLTable_Original(DataRow dr)
        {
            this.TABLE_NAME = dr["TABLE_NAME"].ToString();
        }
    }
}
