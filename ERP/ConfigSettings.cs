using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace ERP;

public class ConfigSettings
{
    public static string? ConnectionString { get; set; }

    private static readonly string JsonPath = "../../../appsettings.json";
    public static void ReadConfigSettings()
    {
        var jsonContent = File.ReadAllText(JsonPath);
        JObject keys = (JObject)JsonConvert.DeserializeObject(jsonContent);
        ConnectionString = keys["ConnectionString"].Value<string>();
    }
}
