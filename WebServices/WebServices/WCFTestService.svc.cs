using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TestService.svc or TestService.svc.cs at the Solution Explorer and start debugging.
    public class WCFTestService : IWCFTestService
    {
        public Student GetStudent()
        {
            return Student.Jubin;
        }

        public string GetStudentJSON()
        {
            return JsonConvert.SerializeObject(Student.Jubin);
        }

        public string GetFullName(Student student)
        {
            return string.Format("{0} {1}", student.FirstName, student.LastName);
        }
    }
}
