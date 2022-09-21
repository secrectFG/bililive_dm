using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bililive_dm.Extension
{
    public static class Extension
    {
        public static string[] ToArray(this System.Collections.Specialized.StringCollection sc)
        {
            var arr = new string[sc.Count];
            for (int i = 0; i < sc.Count; i++)
            {
                arr[i] = sc[i];
            }
            return arr;
        }
    }
}
