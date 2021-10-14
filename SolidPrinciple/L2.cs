using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.L2
{
    public class File
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

    public class ReadOnlyFile : File
    {
        public new string LoadData()
        {
            var data = string.Empty;

            //Logic to read data from file.

            return data;
        }

        public new void SaveData()
        {
            //Throw an exception when try to save.
            throw new Exception("Can't save it into file!");
        }
    }

    public class FileManager
    {
        public string ReadDataFromFile(File file)
        {
            return file.LoadData();
        }

        public void SaveDataIntoFile(File file)
        {
            if (file is not ReadOnlyFile)
            {
                file.SaveData();
            }
        }
    }    
}
