using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMA.AssetBundles;

namespace UnityEngine
{
    public static class JsonUtility
    {
        public static string ToJson(object obj)
        {
            return "";
        }

        public static T FromJson<T>(string strObj)
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }

        public static void FromJsonOverwrite(string readAllText, AssetBundleIndex assetBundleIndexObject)
        {
            throw new NotImplementedException();
        }
    }
}
