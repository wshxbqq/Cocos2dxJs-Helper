using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace CoccosHelper
{
    class JS
    {
       public static void createFilesJs()
        {

            StringBuilder sb = new StringBuilder();
            DirectoryInfo di = new DirectoryInfo(Global.PATH + "/src");

            foreach (FileInfo fi in di.GetFiles("*", SearchOption.AllDirectories))
            {
                if (fi.Name.Contains(".manifest") || fi.Name.Contains("files.js"))
                {
                    continue;
                }

                sb.Append("\"src" + fi.FullName.Replace(di.FullName, "") + "\",");
                sb.Append(Environment.NewLine);
            }

            string result = CoccosHelper.Properties.Resources.files.Replace("#1#", sb.ToString().Trim().Trim(',').Replace("\\", "/"));
            File.WriteAllText(Global.PATH + "/src/files.js", result);

        }
    }
}
