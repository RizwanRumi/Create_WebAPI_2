using S3LabTestWebApi.IBll;
using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace S3LabTestWebApi.BL
{
    public class LanguageManager : ILanguage
    {
        S3LabTestDBEntities _dbContext = new S3LabTestDBEntities();

        public List<LanguageDetailsModel> GetAllLanguages()
        {
            List<LanguageDetailsModel> languageList = new List<LanguageDetailsModel>();
            var details = _dbContext.tblLanguages;
            if (details != null)
            {
                Parallel.ForEach(details, x =>
                {
                    LanguageDetailsModel obj = new LanguageDetailsModel();
                    obj.LanguageId = x.colLanguageId;
                    obj.LanguageName = x.colLanguageName;
                    obj.LanguageShortName = x.colLanguageShortName;
                   
                    languageList.Add(obj);

                });
                return languageList;
            }
            else
            {
                return languageList;
            }
        }

        public bool saveSelectedLang(SylbLanguages langs)
        {          
             
            foreach (var sl in langs.SelectedLangs)
            {
                tblSyllabusLanguage lng = new tblSyllabusLanguage();
                lng.colSyllabusId = langs.SylbId;
                lng.colLanguageId = sl;

                _dbContext.tblSyllabusLanguages.Add(lng);
                _dbContext.SaveChanges();
            }

            return true;
        }
    }
}