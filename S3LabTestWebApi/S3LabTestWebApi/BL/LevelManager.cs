using S3LabTestWebApi.IBll;
using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace S3LabTestWebApi.BL
{
    public class LevelManager : ILevel
    {
        S3LabTestDBEntities _dbContext = new S3LabTestDBEntities();

        public List<LevelDetailsModel> GetAllLevels()
        {
            List<LevelDetailsModel> lavelList = new List<LevelDetailsModel>();
            var details = _dbContext.tblLevels;
            if (details != null)
            {
                Parallel.ForEach(details, x =>
                {
                    LevelDetailsModel obj = new LevelDetailsModel();
                    obj.LevelId = x.colLevelId;
                    obj.LevelName = x.colLevelName;
                    obj.LevelShortName = x.colLevelShortName;
                    obj.TradeId = x.colTradeId;
                   

                    lavelList.Add(obj);

                });
                return lavelList;
            }
            else
            {
                return lavelList;
            }
        }
    }
}