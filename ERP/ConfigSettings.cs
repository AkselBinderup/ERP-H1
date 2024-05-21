using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ERP
{
    public class ConfigSettings
    {
        public static string? ConnectionString { get; private set; }

        private static readonly string JsonPath = "../../../appsettings.json";
        public static void ReadConfigSettings()
        {
            var jsonContent = File.ReadAllText(JsonPath);
            JObject keys = (JObject)JsonConvert.DeserializeObject(jsonContent);
            ConnectionString = keys[nameof(ConnectionString)]?.Value<string>() ?? string.Empty;
        }
    }
}
