using Newtonsoft.Json;
using System.Web.Script.Services;
using System.Web.Services;
namespace WebServices
{
    /// <summary>
    /// Summary description for TestService
    /// </summary>
    /// 

    [WebService(Namespace = "http:/www.jubin.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class TestService : System.Web.Services.WebService
    {
        [WebMethod]
        public Student  GetStudent()
        {
            return Student.Jubin;
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]//By default get and post both allowed
        [WebMethod]
        public string GetStudentJSON()
        {
            return JsonConvert.SerializeObject(Student.Jubin);
        }
    }
}
