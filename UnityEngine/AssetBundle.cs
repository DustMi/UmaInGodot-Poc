using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class AssetBundle : Object
    {

        public Object LoadAsset(string name)
        {
            return new Object();
        }

        public T LoadAsset<T>(string name)
        {
            Type type = typeof(T);
            return (T) Activator.CreateInstance(type);
        }

    }
}
