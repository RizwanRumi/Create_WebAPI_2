using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S3LabTestWebApi.Models
{
    public class SyllabusMergeModel
    {
        public int SyllabusMergeId { get; set; }
        public string SyllabusMergeName { get; set; }
        public string TradeName { get; set; }
        public string LevelName { get; set; }
        public string SyllabusMDocUrl { get; set; }
        public string TestPlanMUrl { get; set; }
        public string Languages { get; set; }        
        public int UploadMBy { get; set; }
        public DateTime SylbUploadDt { get; set; }
        public DateTime SylbActiveDt { get; set; }
        public int Status { get; set; }
    }
}