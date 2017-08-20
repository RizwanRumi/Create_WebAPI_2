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
     [RoutePrefix("api/Level")]
    public class LevelController : ApiController
    {
        private ILevel ilevelDetails;
        public LevelController(ILevel _ilevelDetails)
        {
            ilevelDetails = _ilevelDetails;
        }


        [Route("GetLevelList")]
        [HttpGet]
        public IHttpActionResult GetLevelList()
        {
            List<LevelDetailsModel> levelList = new List<LevelDetailsModel>();
            
            //var details = ilevelDetails.GetAllLevels();
            //foreach (var x in details)
            //{
            //    LevelDetailsModel lvl = new LevelDetailsModel();
            //    lvl.LevelId = x.LevelId;
            //    lvl.LevelName = x.LevelName;
            //    lvl.LevelShortName = x.LevelShortName;
            //    lvl.TradeId = x.TradeId;

            //    li.Add(lvl);
            //}
            
            levelList = ilevelDetails.GetAllLevels();

            if (levelList.Count == 0)
            {
                return NotFound();
            }
            
            return Ok(levelList);
        }
    }
}
