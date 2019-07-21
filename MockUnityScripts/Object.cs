using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Object
    {
        public string name
        {
            get; set;
        }

        public static implicit operator bool(Object exists)
        {
            return !object.ReferenceEquals(exists, null);
        }

        public static void DontDestroyOnLoad(Object target)
        {
            //doing nothing
        }

        public static Object[] FindObjectsOfType(Type type)
        {
            return new Object[0];
        }
    }
}
