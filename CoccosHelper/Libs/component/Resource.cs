using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using LitJson;
namespace CoccosHelper
{
    class Resource
    {


        public static void createResource()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            DirectoryInfo di = new DirectoryInfo(Global.PATH + "/res");
            var jd = new LitJson.JsonData();
            FileInfo[] fs = di.GetFiles("*", SearchOption.TopDirectoryOnly);

            foreach (FileInfo fi in fs)
            {
                if (fi.Name.Contains(".manifest"))
                {
                    continue;
                }

                string pPath = "res/" + fi.Name;
                jd[pPath.Replace("/", "@").Replace("\\", "@")] = pPath;
            }


            getJsonData(jd,"");
            JsonWriter writer = new JsonWriter(sb);
            writer.PrettyPrint = true;
            writer.IndentValue = 4;
            jd.ToJson(writer);
             
            

 
            string result = CoccosHelper.Properties.Resources.tpl.Replace("#1#", sb.ToString());
            File.WriteAllText(Global.PATH + "/src/resource.js", result);

        }

        public static LitJson.JsonData getJsonData(LitJson.JsonData jd,string shortPath) {
            DirectoryInfo diRes = new DirectoryInfo(Global.PATH + "/res");

            string o = Global.PATH + "/res/" + shortPath;
            DirectoryInfo di = new DirectoryInfo(o);

            foreach (DirectoryInfo _di in di.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {
                if (_di.Name == "slice" && Global.slice)
                {
                    continue;
                }
                jd[_di.Name]= Resource.getJson4Folder(shortPath+"/"+ _di.Name);
                var sPath = _di.FullName.Replace(diRes.FullName, "").Trim('\\');
                getJsonData(jd[_di.Name], shortPath + "/" + _di.Name);
            }
            return jd;

        }

        public static LitJson.JsonData getJson4Folder(string path) {
            path = path.Trim('\\').Trim('/');
            LitJson.JsonData jd = new LitJson.JsonData();
            DirectoryInfo di = new DirectoryInfo(Global.PATH + "/res/"+path);
            FileInfo[] fs= di.GetFiles("*",SearchOption.TopDirectoryOnly);
 
            foreach (FileInfo fi in fs) {
                if (fi.Name.Contains(".manifest"))
                {
                    continue;
                }

                string pPath = "res/"+path + "/" + fi.Name;
                jd[pPath.Replace("/", "@").Replace("\\", "@")] = pPath;
            }
            return jd;
        }

        public static void removeSlice() {
            DirectoryInfo di = new DirectoryInfo(Global.PATH + "/res");
            var ds = di.GetDirectories("*",SearchOption.AllDirectories);
            foreach (DirectoryInfo d in ds) {
                if (d.Name.ToLower()=="slice") {
                    if (d.Exists) {
                        d.Delete(true);
                    }
                }
            }
        }
    }
}
