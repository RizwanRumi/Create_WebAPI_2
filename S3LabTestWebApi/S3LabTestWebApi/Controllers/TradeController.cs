using S3LabTestWebApi.IBll;
using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace S3LabTestWebApi.Controllers
{
    [RoutePrefix("api/Trade")]
    public class TradeController : ApiController
    {
        private ITrade itradeDetails;
        public TradeController(ITrade _itradeDetails)
        {
            itradeDetails = _itradeDetails;
        }


        [Route("GetTradeList")]
        [HttpGet]
        public IHttpActionResult GeTradetList()
        {
            List<TradeDetailsModel> tradeList = new List<TradeDetailsModel>();            
            //var details = itradeDetails.GetAllTrades();
            //foreach (var x in details)
            //{
            //    TradeDetailsModel trd = new TradeDetailsModel();
            //    trd.TradeId = x.TradeId;
            //    trd.TradeCode = x.TradeCode;
            //    trd.TradeName = x.TradeName;
            //    trd.Abbreviation = x.Abbreviation;
            //    trd.Status = Convert.ToInt32(x.Status);

            //    tradeList.Add(trd);
            //}
            tradeList = itradeDetails.GetAllTrades();

            //if (tradeList.Count == 0)
            //{
            //    return NotFound();
            //}

            return Ok(tradeList);            
        }
    }
}
