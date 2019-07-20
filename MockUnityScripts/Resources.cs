using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUnityScripts
{
    public class Resources
    {
        public static T[] LoadAll<T>(string path)
        {
            Type type = typeof(T);
            var myReturn = (T[]) Activator.CreateInstance(type, new object[] { 1 });
            return myReturn;
        }
    }
}
