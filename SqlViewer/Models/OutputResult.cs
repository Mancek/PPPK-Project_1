﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlViewer.Models
{
    class OutputResult
    {
        public string Message { get; set; }
        public List<DataTable> Data { get; set; }
    }
}