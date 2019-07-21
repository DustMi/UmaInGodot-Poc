using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Resources
    {
        public static T[] LoadAll<T>(string path)
        {
            Type type = typeof(T);
            var myReturn = (T[]) Activator.CreateInstance(type, new object[] { 1 });
            return myReturn;
        }

        public static T Load<T>(string path) where T : Object
        {
            Type type = typeof(T);
            return (T) Activator.CreateInstance(type);
        }
    }
}
