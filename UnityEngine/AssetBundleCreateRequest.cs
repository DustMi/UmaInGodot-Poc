using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class AssetBundleCreateRequest : AsyncOperation
    {
        internal float progress;
        internal AssetBundle assetBundle;
        public bool isDone;
    }
}
