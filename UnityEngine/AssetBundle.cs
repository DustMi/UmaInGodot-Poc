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

        public Object LoadAsset(string name, Type type)
        {
            throw new NotImplementedException();
        }

        public T LoadAsset<T>(string name)
        {
            Type type = typeof(T);
            return (T) Activator.CreateInstance(type);
        }

        public AssetBundleRequest LoadAssetAsync<T>(string name)
        {
            throw new NotImplementedException();
        }

        public AssetBundleRequest LoadAssetAsync(string name, System.Type type)
        {
            if (name == null)
                throw new NullReferenceException("The input asset name cannot be null.");
            if (name.Length == 0)
                throw new ArgumentException("The input asset name cannot be empty.");
            if (type == null)
                throw new NullReferenceException("The input type cannot be null.");
            return this.LoadAssetAsync_Internal(name, type);
        }

        private extern AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type);

        public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary)
        {
            throw new NotImplementedException();
        }

        internal void Unload(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
