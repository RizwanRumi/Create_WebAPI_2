using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3LabTestWebApi.IBll
{
    public interface ILanguage
    {
        List<LanguageDetailsModel> GetAllLanguages();
    }
}
