using JsonHelper;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models.Users
{
    public partial class UserModel
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public long Password { get; set; }
    }
    public partial class UserModel
    {
        public static List<UserModel> FromJson(string json) => JsonConvert.DeserializeObject<List<UserModel>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<UserModel> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
