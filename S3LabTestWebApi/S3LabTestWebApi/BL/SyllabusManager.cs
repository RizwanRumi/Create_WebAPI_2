using S3LabTestWebApi.IBll;
using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace S3LabTestWebApi.BL
{
    public class SyllabusManager : ISyllabus
    {
        S3LabTestDBEntities _dbContext = new S3LabTestDBEntities();

        public List<SyllabusDetailsModel> showSylbList()
        {
            List<SyllabusDetailsModel> sylabusList = new List<SyllabusDetailsModel>();
            var details = _dbContext.tblSyllabus;
            if (details != null)
            {
                Parallel.ForEach(details, x =>
                {
                    SyllabusDetailsModel obj = new SyllabusDetailsModel();
                    obj.SyllabusId = x.colSyllabusId;
                    obj.SyllabusName = x.colSyllabusName;
                    obj.TradeId = x.colTradeId;
                    obj.LevelId = x.colLevelId;
                    obj.SyllabusDocUrl = x.colSyllabusDocUrl;
                    obj.TestPlanUrl = x.colTestPlanUrl;
                    obj.DevelopmentOfficer = x.colDevelopmentOfficer;
                    obj.Manager = x.colManager;
                    obj.UploadBy = x.colUploadBy;
                    obj.UploadDt = x.colUploadDt;
                    obj.ActiveDt = x.colActiveDt;
                    obj.Status = Convert.ToInt32(x.colSt);

                    sylabusList.Add(obj);

                });
                return sylabusList;
            }
            else
            {
                return sylabusList;
            }
        }

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


        public List<SyllabusMergeModel> GetSyllabusList()
        {
            List<SyllabusMergeModel> slmergeList = new List<SyllabusMergeModel>();

            var details = _dbContext.tblSyllabus;
            var tradeList = _dbContext.tblTrades;
            var levelList = _dbContext.tblLevels;
            var selectedLangList = _dbContext.tblSyllabusLanguages;
            var languages = _dbContext.tblLanguages;

            foreach (var x in details)
            {

                SyllabusMergeModel obj = new SyllabusMergeModel();
                obj.SyllabusMergeId = x.colSyllabusId;
                obj.SyllabusMergeName = x.colSyllabusName;


                foreach (var td in tradeList)
                {
                    if (td.colTradeId == x.colTradeId)
                    {
                        obj.TradeName = td.colAbbreviation;
                    }
                }

                foreach (var lv in levelList)
                {
                    if (lv.colLevelId == x.colLevelId)
                    {
                        obj.LevelName = lv.colLevelShortName;
                    }
                }

                var array = from ln in selectedLangList
                            where ln.colSyllabusId == x.colSyllabusId
                            select ln.colLanguageId;

                List<int> langArray = new List<int>();

                foreach(var ln in selectedLangList)
                {
                    if(ln.colSyllabusId == x.colSyllabusId)
                    {
                        langArray.Add(ln.colLanguageId);
                    }
                }

                int len = langArray.Count;
                string str = "";

                for (int k = 0; k < len; k++)
                {
                    foreach (var lName in languages)
                    {
                        if (langArray[k] == lName.colLanguageId)
                        {
                            str += lName.colLanguageShortName + ", ";
                        }
                        
                    }
                }
                obj.Languages = str.Remove(str.Length - 2);
					

                obj.SyllabusMDocUrl = x.colSyllabusDocUrl;
                obj.TestPlanMUrl = x.colTestPlanUrl;
                obj.UploadMBy = x.colUploadBy;
                obj.SylbUploadDt = x.colUploadDt;
                obj.SylbActiveDt = x.colActiveDt;
                obj.Status = Convert.ToInt32(x.colSt);


                slmergeList.Add(obj);
            }

                return slmergeList;
            }

    }
}