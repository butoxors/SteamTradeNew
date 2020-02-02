using JsonHelper;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models
{
    public abstract class BaseModel<T>
    {
        public static string ToJson(List<T> self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static List<T> FromJsonToList(string json) => JsonConvert.DeserializeObject<List<T>>(json, Converter.Settings);
        public static T FromJson(string json) => JsonConvert.DeserializeObject<T>(json, Converter.Settings);
    }
}
