using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Texture : Object
    {
        public int height
        {
            get;
        }

        public int width
        {
            get;
        }
        public TextureWrapMode wrapMode { set; get; }
        public float mipMapBias;
        public FilterMode filterMode;
        public int anisoLevel;
    }
}

