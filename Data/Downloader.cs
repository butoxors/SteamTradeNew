using Enums;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Data
{
    public class Downloader
    {
        public string DownloadString(Enum uri)
        {
            WebClient client = new WebClient();
            return client.DownloadString(uri.GetDescription());
        }

        public async Task<string> GetXHR(Enum uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri.GetDescription());
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
