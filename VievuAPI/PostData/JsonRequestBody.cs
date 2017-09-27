using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using VievuAPI.PostData;
namespace VievuAPI.PostData
{
    class JsonRequestBody
    {
        private  DateTime now = DateTime.Now;
        public string GetJsonbody()
        {
            JsonDataProperty Result = new JsonDataProperty();
            Result.ID = Guid.NewGuid();
            Result.TestSuiteName = "Persona";
            Result.ModuleName = "Persona";
            Result.SubModuleName = "Add Case";
            Result.TestCase = "Ensure User able to Create New Case";
            Result.ActionResult = "";
            Result.ExpectedResult = "Verify created Case  display in List";
            Result.Status = "Passed";
            Result.Error = "";
            Result.Browser = "";
            Result.SUT = "API";
            Result.TestCaseType = "Smoke";
            Result.CreatedOn = now;
            string JsonString = JsonConvert.SerializeObject(Result);
            return JsonString;
        }
    }
}
