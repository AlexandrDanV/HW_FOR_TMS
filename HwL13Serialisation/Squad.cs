using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HwL13Serialisation
{
    public class Squad
    {
        [JsonPropertyName("squadName")]     
        public string SquadName { get; set; }
        [JsonPropertyName("homeTown")]

        public string HomeTown { get; set; }

        [JsonPropertyName("formed")]

        public int Formed { get; set; }
        [JsonPropertyName("secretBase")]
        public string Base { get; set; }
        [JsonPropertyName("active")]
        public bool isActive { get; set; }
        [JsonPropertyName("members")]
        public List<Members> members { get; set; }
        [JsonConstructor]
        public Squad()
        {
            members = new List<Members>();
            members.Add(new Members());
        }
    }
}
