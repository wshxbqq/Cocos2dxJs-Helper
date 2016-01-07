using System;
using System.Collections.Generic;
using System.Text;

namespace CoccosHelper
{
    class Global
    {
       public static string PATH = System.Environment.CurrentDirectory;

        public static bool slice = true;


        public  static  string  convertPath2Linux(string path) {
            return path.Replace("\\", "/");
        }
    }
}
