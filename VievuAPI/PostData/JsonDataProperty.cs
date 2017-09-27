using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievuAPI.PostData
{
    class JsonDataProperty
    {
        public Guid ID { get; set; }
        public String TestSuiteName { get; set; }
        public String ModuleName { get; set; }
        public String SubModuleName { get; set; }
        public String TestCase { get; set; }
        public String ActionResult { get; set; }
        public String ExpectedResult { get; set; }
        public String Status { get; set; }
        public String Error { get; set; }
        public String Browser { get; set; }
        public String SUT { get; set; }
        public String TestCaseType { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
