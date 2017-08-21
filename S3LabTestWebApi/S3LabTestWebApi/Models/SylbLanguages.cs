using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S3LabTestWebApi.Models
{
    public class SylbLanguages
    {
        public int SylbId { get; set; }
        public List<int> SelectedLangs { get; set; }
    }
}