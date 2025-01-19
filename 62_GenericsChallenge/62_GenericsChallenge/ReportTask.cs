using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_GenericsChallenge
{
    internal class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }
        public string Perform()
        {
            return $"Report {ReportName} generated successfully";
        }
    }
}
