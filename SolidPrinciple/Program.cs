using System;

namespace Amalay.SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //S: Single Responsibility Principle (SRP)
            var userRegistration1 = new S1.UserRegistration();
            userRegistration1.RegisterUser("Amalay", "av@xyz.com", "password");

            var userRegistration2 = new S2.UserRegistration();
            userRegistration2.RegisterUser("Amalay", "av@xyz.com", "password");

            //O: Open Closed Principle (OSP)
            var calculator1 = new O1.Calculator();
            var area1 = calculator1.CalculateArea(new O1.Rectangle() { Width = 10, Height = 5 });

            var calculator2 = new O2.Calculator();
            var area2 = calculator2.CalculateArea(new O2.Rectangle() { Width = 10, Height = 5 });
            var area3 = calculator2.CalculateArea(new O2.Circle() { Radius = 5 });

            var calculator3 = new O3.Calculator();
            var area4 = calculator3.CalculateArea(new O3.Rectangle() { Width = 10, Height = 5 });
            var area5 = calculator3.CalculateArea(new O3.Circle() { Radius = 5 });

            //L: Liskov Substitution Principle (LSP)
            var fileManager1 = new L1.FileManager();
            var data1 = fileManager1.ReadDataFromFile(new L1.File() { FilePath = "C:\temp" });
            fileManager1.SaveDataIntoFile(new L1.File() { FilePath = "C:\temp", FileContent = "xxxxxxxxxx-xxxxxxxx-xxxxxx" });

            var fileManager2 = new L2.FileManager();
            var data2 = fileManager2.ReadDataFromFile(new L2.File() { FilePath = "C:\temp" });
            fileManager2.SaveDataIntoFile(new L2.File() { FilePath = "C:\temp", FileContent = "xxxxxxxxxx-xxxxxxxx-xxxxxx" });

            var fileManager3 = new L3.FileManager();
            var data3 = fileManager3.ReadDataFromFile(new L3.ReadOnlyFile() { FilePath = "C:\temp" });
            fileManager3.SaveDataIntoFile(new L3.ReadWriteFile() { FilePath = "C:\temp", FileContent = "xxxxxxxxxx-xxxxxxxx-xxxxxx" });

            //I: Interface Segregation Principle (ISP)

            //D: Depedency Inversion Principle (DIP)
        }
    }
}
