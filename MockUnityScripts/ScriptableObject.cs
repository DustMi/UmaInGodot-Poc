using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUnityScripts
{
    public class ScriptableObject
    {
        public string name
        {
            get; set;
        }

        public static T CreateInstance<T>()
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }

        public static implicit operator bool(ScriptableObject exists)
        {
            return !object.ReferenceEquals(exists, null);
        }
    }
}
