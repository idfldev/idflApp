using idflApp.Constants;

namespace idflApp.Utils
{
    public class CheckExistFileUtils
    {
        internal static string CheckExistFile(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                string pathFile = Path.Combine(StaticPathFile.staticPath);
                if (System.IO.File.Exists(pathFile))
                {
                    return value;
                }
            }
            // throw new ArgumentException(value + "was not exist");
            return "";
        }
    }
}