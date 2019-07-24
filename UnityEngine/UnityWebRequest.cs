using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class UnityWebRequest
    {
        public string url;
        internal string error;
        internal float downloadProgress;
        internal bool isDone;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal static UnityWebRequest GetAssetBundle(string m_Url, Hash128 hash128, int v)
        {
            throw new NotImplementedException();
        }

        internal static UnityWebRequest GetAssetBundle(string m_Url)
        {
            throw new NotImplementedException();
        }
    }
}
