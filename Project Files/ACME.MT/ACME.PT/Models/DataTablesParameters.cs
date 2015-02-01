using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Attendance.Models
{
    public class DataTablesParameters
    {
        public string sEcho { get; set; }
        public string Search { get; set; }
        public int iDisplayLength { get; set; }
        public int iDisplayStart { get; set; }
        public int iColumns { get; set; }
        public int iSortingCols { get; set; }
        public string sColumns { get; set; }

    }
}