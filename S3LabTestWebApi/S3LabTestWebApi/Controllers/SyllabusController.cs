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

        [Route("GeTSyllabus")]
        [HttpGet]
        public IHttpActionResult GetSyllabusList()
        {
            List<SyllabusDetailsModel> sylbList = new List<SyllabusDetailsModel>();
            sylbList = isyllabusDetails.showSylbList();
            return Ok(sylbList);
        }

        [Route("getMergeSyllabus")]
        [HttpGet]
        public IHttpActionResult getMergeSyllabus()
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

    }
}
