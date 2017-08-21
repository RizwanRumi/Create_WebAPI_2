using S3LabTestWebApi.IBll;
using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S3LabTestWebApi.BL
{
    public class SyllabusManager : ISyllabus
    {
        S3LabTestDBEntities _dbContext = new S3LabTestDBEntities();

        public int SaveSyllabus(SyllabusDetailsModel slb)
        {
            int id = 0;
            tblSyllabu sb = new tblSyllabu();

            sb.colSyllabusId = slb.SyllabusId;
            sb.colSyllabusName = slb.SyllabusName;
            sb.colTradeId = slb.TradeId;
            sb.colLevelId = slb.LevelId;
            sb.colSyllabusDocUrl = slb.SyllabusDocUrl;
            sb.colTestPlanUrl = slb.TestPlanUrl;
            sb.colDevelopmentOfficer = slb.DevelopmentOfficer;
            sb.colManager = slb.Manager;
            sb.colUploadBy = slb.UploadBy;
            sb.colUploadDt = slb.UploadDt;
            sb.colActiveDt = slb.ActiveDt;
            sb.colSt = Convert.ToBoolean(slb.Status);

            
            _dbContext.tblSyllabus.Add(sb);

            _dbContext.SaveChanges();

            id = sb.colSyllabusId;
          
            return id;
        }

    }
}