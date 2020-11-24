using Xunit;
using PracticeSingleResponsibilityPrinciple.Sample2.AfterSRP;
using System;

namespace Test.Sample2.AfterSRP
{
    public class TestEntryManagers
    {
        public class TestWorkReport
        {
            [Fact]
            public void ToString_Calculated()
            {
                var report = new WorkReport();
                report.AddEntry(new WorkReportEntry {
                    ProjectCode = "XXXX",
                    ProjectName = "TEST",
                    SpentHours = 5
                });

                string expected = "Code: XXXX, Name: TEST, Hours: 5";
                string actual = report.ToString();
                Assert.Equal(expected, actual);
            }
        }

        public class TestScheduler
        {
            [Fact]
            public void ToString_Calculated()
            {
                var schedule = new Scheduler();
                schedule.AddEntry(new ScheduleTask
                {
                    Content = "XXXX",
                    ExecuteOn = DateTime.Now,
                    TaskId = 5
                });

                string expected = $"TaskId: 5, Content: XXXX, ExecutedOn: {DateTime.Now}";
                string actual = schedule.ToString();
                Assert.Equal(expected, actual);
            }
        }
    }
}
