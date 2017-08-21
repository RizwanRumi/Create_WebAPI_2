using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S3LabTestWebApi.Models
{
    public class SyllabusDetailsModel
    {
        public int SyllabusId { get; set; }
        public string SyllabusName { get; set; }
        public int TradeId { get; set; }
        public int LevelId { get; set; }
        public string SyllabusDocUrl { get; set; }
        public string TestPlanUrl { get; set; }
        public string DevelopmentOfficer { get; set; }
        public string Manager { get; set; }
        public int UploadBy { get; set; }
        public DateTime UploadDt { get; set; }
        public DateTime ActiveDt { get; set; }
        public int Status { get; set; }

    }
}