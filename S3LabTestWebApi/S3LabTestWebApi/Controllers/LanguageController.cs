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
    [RoutePrefix("api/Language")]
    public class LanguageController : ApiController
    {
        private ILanguage ilanguageDetails;
        public LanguageController(ILanguage _ilanguageDetails)
        {
            ilanguageDetails = _ilanguageDetails;
        }


        [Route("GetLanguages")]
        [HttpGet]
        public IHttpActionResult GeLanguageList()
        {
            List<LanguageDetailsModel> langList = new List<LanguageDetailsModel>();
           
            //var details = ilanguageDetails.GetAllLanguages();
            //foreach (var x in details)
            //{
            //    LanguageDetailsModel lang = new LanguageDetailsModel();
            //    lang.LanguageId = x.LanguageId;
            //    lang.LanguageName = x.LanguageName;
            //    lang.LanguageShortName = x.LanguageShortName;
               
            //    li.Add(lang);
            //}

            langList = ilanguageDetails.GetAllLanguages();
            return Ok(langList);
        }

        [Route("addSelectedLang")]
        [HttpPost]
        public IHttpActionResult PostSelectedLang(SylbLanguages langslist)
        {
            bool result;
            result = ilanguageDetails.saveSelectedLang(langslist);
            return Ok(result);
        }
    }
}
