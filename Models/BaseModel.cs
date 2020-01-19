using Json;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models
{
    public abstract class BaseModel<T>
    {
        public string ToJson(List<T> self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public List<T> FromJson(string json) => JsonConvert.DeserializeObject<List<T>>(json, Converter.Settings);
    }
}
