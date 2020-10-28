using System;

namespace PracticeSingleResponsibilityPrinciple.Sample1.BeforeSRP
{
    /// <summary>
    /// This class is temporary class to run the sample code.
    /// </summary>
    public class DataContext : IDisposable
    {
        public void Dispose()
        { }

        public DataContext Orders => this;

        public void Add(Order order)
        { }

        public void SaveChanges()
        { }
    }
}
