using System.Text.Json;
using System.Xml.Serialization;

namespace HwL13Serialisation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pathToFolder = @"C:\MyFolder\c#\TeachMeSkeals\JsonFolder";
            var validationFolder = ValidationFolder.Validation(pathToFolder);
            if (validationFolder.Item1 is false)
            {
                Console.WriteLine(validationFolder.Item2);
                Console.ReadLine();
            }
            var allFiles = Directory.GetFiles(pathToFolder, "*.json");
            var squad = new Squad();
            using (FileStream file = new FileStream(allFiles[0], FileMode.Open))
            {
                squad = JsonSerializer.Deserialize<Squad>(file);
                Console.WriteLine("Deserialization \"JsonFile\" had done successful.");
            }
            //Serialisation XML
            var xmlSerializer = new XmlSerializer(typeof(Squad));
            using (var fs = new FileStream("squad.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, squad);
                Console.WriteLine("The Serialization to XML format was successful.");
            }
            Console.ReadLine();
        }
    }
}
