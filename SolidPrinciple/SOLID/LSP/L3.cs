using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.L3
{
    public interface IReadableFile
    {
        string LoadData();
    }

    public interface IWritableFile
    {
        void SaveData();
    }

    public class ReadOnlyFile : IReadableFile
    {
        public string FilePath { get; set; }

        public string FileContent { get; set; }

        public string LoadData()
        {
            var data = string.Empty;

            //Logic to read data from file.

            return data;
        }
    }

    public class ReadWriteFile : IWritableFile, IReadableFile
    {
        public string FilePath { get; set; }

        public string FileContent { get; set; }

        public string LoadData()
        {
            var data = string.Empty;

            //Logic to read data from file.

            return data;
        }

        public void SaveData()
        {
            //Logic to save data into file.
        }
    }

    public class FileManager
    {
        public string ReadDataFromFile(IReadableFile file)
        {            
            return file.LoadData();
        }

        public void SaveDataIntoFile(IWritableFile file)
        {
            file.SaveData();
        }
    }
}
