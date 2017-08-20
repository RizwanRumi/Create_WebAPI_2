using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S3LabTestWebApi.Models
{
    public class TradeDetailsModel
    {
        public int TradeId { get; set; }
        public string TradeCode { get; set; }
        public string TradeName { get; set; }
        public string Abbreviation { get; set; }
        public int Status { get; set; }
    }
}