using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSingleResponsibilityPrinciple.Sample2.AfterSRP
{
    public class WorkReport : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry)
        {
            _entries.Add(entry);
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(
                Environment.NewLine,
                _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}")
            );
        }
    }
}
