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
            tblSyllabus sb = new tblSyllabus();
           // sb.colSyllabusId = slb.SyllabusId;
            //sb.colSyllabusName = slb.SyllabusName;
            //sb.colTradeId = slb.TradeId;
            //sb.colLevelId = slb.LevelId;
            //sb.colSyllabusDocUrl = slb.SyllabusDocUrl;
            //sb.colTestPlanUrl = slb.TestPlanUrl;
            //sb.colDevelopmentOfficer = slb.DevelopmentOfficer;
            //sb.colManager = slb.Manager;
            //sb.colUploadBy = slb.UploadBy;
            //sb.colUploadDt = slb.UploadDt;
            //sb.colActiveDt = slb.ActiveDt;
            //sb.colSt = Convert.ToBoolean(slb.Status);

            sb.colSyllabusName = "Test";
            sb.colTradeId = 2;
            sb.colLevelId = 3;
            sb.colSyllabusDocUrl = "DocTest.docx";
            sb.colTestPlanUrl = "PlanTest.xml";
            sb.colDevelopmentOfficer = "Rizwan";
            sb.colManager = "Rumi";
            sb.colUploadBy = 2;
            sb.colUploadDt = DateTime.Now;
            sb.colActiveDt = DateTime.Now;
            sb.colSt = true;
            
            _dbContext.tblSyllabus1.Add(sb);

            _dbContext.SaveChanges();

            id = sb.colSyllabusId;
          
            return id;
        }

    }
}