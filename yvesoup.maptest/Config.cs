using System.Text.Json.Serialization;

namespace yvesoup.maptest;

public class Config {
    [JsonInclude] public bool SomeSetting = true;
}
