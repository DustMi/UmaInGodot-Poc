using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class DownloadHandlerAssetBundle
    {
        public static AssetBundle GetContent(UnityWebRequest www)
        {
            throw new Exception();
            //return DownloadHandler.GetCheckedDownloader<DownloadHandlerAssetBundle>(www).assetBundle;
        }
    }
}
