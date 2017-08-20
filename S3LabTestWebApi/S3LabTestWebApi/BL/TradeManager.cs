using S3LabTestWebApi.IBll;
using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace S3LabTestWebApi.BL
{
    public class TradeManager : ITrade
    {
        S3LabTestDBEntities _dbContext = new S3LabTestDBEntities();

        public List<TradeDetailsModel> GetAllTrades()
        {
            List<TradeDetailsModel> tradeList = new List<TradeDetailsModel>();
            var details = _dbContext.tblTrades;
            if (details != null)
            {
                Parallel.ForEach(details, x =>
                {
                    TradeDetailsModel obj = new TradeDetailsModel();
                    obj.TradeId = x.colTradeId;
                    obj.TradeCode = x.colTradeCode;
                    obj.TradeName = x.colTradeName;
                    obj.Abbreviation = x.colAbbreviation;
                    obj.Status = Convert.ToInt32(x.colSt);

                    tradeList.Add(obj);

                });
                return tradeList;
            }
            else
            {
                return tradeList;
            }
        }
    }
}