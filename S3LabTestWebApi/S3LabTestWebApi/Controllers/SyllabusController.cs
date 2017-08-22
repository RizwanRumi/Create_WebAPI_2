using S3LabTestWebApi.IBll;
using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace S3LabTestWebApi.Controllers
{
    [RoutePrefix("api/Syllabus")]
    public class SyllabusController : ApiController
    {
        ISyllabus isyllabusDetails;
        public SyllabusController(ISyllabus _isyllabusDetails)
        {
            isyllabusDetails = _isyllabusDetails;
        }             

        [Route("getSyllabus")]
        [HttpGet]
        public IHttpActionResult GetSyllabusList()
        {
            List<SyllabusMergeModel> sylbList = new List<SyllabusMergeModel>();
            sylbList = isyllabusDetails.GetSyllabusList();
            return Ok(sylbList);
        }

        [Route("addSyllabus")]
        [HttpPost]
        public IHttpActionResult PostSyllabus(SyllabusDetailsModel sylb)
        {
            int res = 0;

            res = isyllabusDetails.SaveSyllabus(sylb);

            return Ok(res);
        }

        [Route("getSortedSyllabus")]
        [HttpGet]
        public IHttpActionResult GetSortedSyllabus(int trade, int level)
        {
            List<SyllabusMergeModel> sortedSylbList = new List<SyllabusMergeModel>();
            sortedSylbList = isyllabusDetails.GetAllSortedList(trade,level);
            return Ok(sortedSylbList);

        }


        [Route("getByTradeId")]
        [HttpGet]
        public IHttpActionResult GetByTrades(int trade)
        {
            List<SyllabusMergeModel> sylbListByTrade = new List<SyllabusMergeModel>();
            sylbListByTrade = isyllabusDetails.GetAllByTradeList(trade);
            return Ok(sylbListByTrade);

        }

        [Route("getByLevelId")]
        [HttpGet]
        public IHttpActionResult GetByLevels(int level)
        {
            List<SyllabusMergeModel> sylbListByTrade = new List<SyllabusMergeModel>();
            sylbListByTrade = isyllabusDetails.GetAllByLevelList(level);
            return Ok(sylbListByTrade);

        }

    }
}
