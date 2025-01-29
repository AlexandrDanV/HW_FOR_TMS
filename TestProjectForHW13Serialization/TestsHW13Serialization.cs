using HwL13Serialisation;
using System.Text.Json;
using System.Xml.Serialization;

namespace TestProjectForHW13Serialization
{
    public class TestsHW13Serialization
    {
        Squad squad = new Squad();
        [Fact]
        public void Validation_GetPathAndDoValidation_ReturnTrueAndEmptyString()
        {
            var pathToFolder = @"C:\MyFolder\c#\TeachMeSkeals\JsonFolder";
            var actual = ValidationFolder.Validation(pathToFolder);
            var expected = (true, "Validation is successful.");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Deserialize_ParsingJsonFile_GetFilledInFields()
        {
            var pathToFolder = @"C:\MyFolder\c#\TeachMeSkeals\JsonFolder";
            var allFiles = Directory.GetFiles(pathToFolder, "*.json");

            using (FileStream file = new FileStream(allFiles[0], FileMode.Open))
            {
                squad = JsonSerializer.Deserialize<Squad>(file);
            }

            var fieldActual = squad.members[1].Powers[1];
            var expected = "Damage resistance";
            Assert.Equal(fieldActual, expected);
        }

        [Fact]
        public void SerializeToXML_GetIsExistFileXML()
        {
            var xmlSerializer = new XmlSerializer(typeof(Squad));
            using (var fs = new FileStream("squad.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, squad);
            }
            var path = @"C:\MyFolder\c#\TeachMeSkeals\HW_FOR_TMS\HwL13Serialisation\bin\Debug\net9.0\";
            var filesXML = Directory.GetFiles(path, "squad.xml*");
            var actual = (filesXML.Length != 0) ? true : false;
            var expected = true;
            Assert.Equal(expected, actual);
        }

    }
}
