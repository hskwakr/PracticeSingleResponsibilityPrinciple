namespace PracticeSingleResponsibilityPrinciple.Sample2.AfterSRP
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntry(int index);
    }
}
