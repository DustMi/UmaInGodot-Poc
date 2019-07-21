using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class ScriptableObject : Object
    {

        public static T CreateInstance<T>()
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }

    }
}
