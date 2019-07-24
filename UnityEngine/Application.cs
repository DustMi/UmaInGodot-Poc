using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Application
    {
        public static RuntimePlatform platform;
        internal static bool isMobilePlatform;
        public static bool isConsolePlatform;
        public static string streamingAssetsPath;
        public static bool isEditor;
        public static bool isWebPlayer;
        public static string absoluteURL;

        static public string dataPath
        {
            get;
        }

        static public bool isPlaying
        {
            get;
        }
        static public string persistentDataPath
        {
            get;
        }
    }
}
