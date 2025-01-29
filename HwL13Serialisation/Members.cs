using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HwL13Serialisation
{
    public class Members
    {
        [JsonPropertyName("name")]
        public string NameMembers { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [JsonPropertyName("secretIdentity")]
        public string SecretIdentity { get; set; }
        [JsonPropertyName("powers")]
        public List<string> Powers { get; set; }

        public Members()
        {
            Powers = new List<string>();
            Powers.Add("");
        }
    }
}
