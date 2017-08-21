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
        public IHttpActionResult GetList()
        {
            int dt = 323423;
            return Ok(dt);
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
