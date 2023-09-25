using System.Text.Json;

namespace Mozzarella_Pizza_Place.Models
{
    public static class ExtensionesDebug
    {  
            private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
