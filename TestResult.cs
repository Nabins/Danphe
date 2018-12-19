using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbOperator
{
    public class TestResult
    {
        public string actualResult;
        public string executionStatus;
        public DateTime startTime, endTime;
        public string failureReason;

        public TestResult(string actualResult, string executionStatus, DateTime startTime, DateTime endTime, string failureReason)
        {
            this.actualResult = actualResult;
            this.executionStatus = executionStatus;
            this.startTime = startTime;
            this.endTime = endTime;
            this.failureReason = failureReason;
        }

    }
}
