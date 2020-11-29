using System.IO;

namespace PracticeSingleResponsibilityPrinciple.Sample2.AfterSRP
{
    public class FileSaver
    {
        public void Save<T>(string directoryPath, string fileName, IEntryManager<T> entry)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), entry.ToString());
        }
    }
}
