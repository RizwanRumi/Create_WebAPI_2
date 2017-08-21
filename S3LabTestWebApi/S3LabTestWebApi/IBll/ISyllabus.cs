using S3LabTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3LabTestWebApi.IBll
{
    public interface ISyllabus
    {
        int SaveSyllabus(SyllabusDetailsModel sylb);        
      //  List<SyllabusDetailsModel> showDetails();
    }
}
