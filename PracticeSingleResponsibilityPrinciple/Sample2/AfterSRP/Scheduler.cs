using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSingleResponsibilityPrinciple.Sample2.AfterSRP
{
    public class Scheduler : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> _scheduleTasks;

        public Scheduler()
        {
            _scheduleTasks = new List<ScheduleTask>();
        }

        public void AddEntry(ScheduleTask entry)
        {
            _scheduleTasks.Add(entry);
        }

        public void RemoveEntry(int index)
        {
            _scheduleTasks.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(
                Environment.NewLine,
                _scheduleTasks.Select(x => $"TaskId: {x.TaskId}, Content: {x.Content}, ExecutedOn: {x.ExecuteOn}")
            );
        }
    }
}
