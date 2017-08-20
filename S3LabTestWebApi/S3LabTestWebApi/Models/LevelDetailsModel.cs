using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S3LabTestWebApi.Models
{
    public class LevelDetailsModel
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public string LevelShortName { get; set; }
        public int TradeId { get; set; }
    }
}