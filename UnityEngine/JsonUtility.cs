using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMA.AssetBundles;
using UMA;
using Newtonsoft.Json;

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
            Godot.GD.Print("Creating " + type.Name + " from JSON String");
            var theObject = JsonConvert.DeserializeObject<T>(strObj);
            return theObject;
        }

        public static void FromJsonOverwrite(string readAllText, AssetBundleIndex assetBundleIndexObject)
        {
            throw new NotImplementedException();
        }
    }
}
