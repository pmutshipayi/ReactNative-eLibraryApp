using Newtonsoft.Json;
using System.IO;

namespace ILabrary.Core
{
    public static class DebugHelper
    {
        public const string file = "C:/Users/user/Documents/new 3.html";
        public static string Write(object content)
        {
            File.WriteAllText(file, content + "");
            return "";
        }

        public static void Append(object content, bool clearBeforeTxt = true)
        {
            File.AppendAllText(file, $"\n{content}");
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
    }
}
