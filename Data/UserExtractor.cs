using Models.Users;
using System.IO;
using System.Linq;

namespace Data
{
    public static class UserExtractor
    {
        private static string path = "UserData.ccs";

        public static UserModel Extract()
        {
            var model = UserModel.FromJson(File.ReadAllText(path));
            return model.First();
        }
    }
}
