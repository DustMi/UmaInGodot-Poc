using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class RenderTexture : Texture
    {
        public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite)
        {
        }
        public void Release()
        {
            throw new NotImplementedException();
        }

        public bool IsCreated()
        {
            throw new NotImplementedException();
        }

        public RenderTextureFormat format;

        public bool useMipMap;
        public static RenderTexture active;
    }
}
