using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Texture2D : Texture
    {
        internal Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear, IntPtr nativeTex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///   <para>Create a new empty texture.</para>
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="textureFormat"></param>
        /// <param name="mipChain"></param>
        /// <param name="linear"></param>
        public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear)
          : this(width, height, textureFormat, mipChain, linear, IntPtr.Zero)
        {
        }

        public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
          : this(width, height, textureFormat, mipChain, false, IntPtr.Zero)
        {
        }

        /// <summary>
        ///   <para>Create a new empty texture.</para>
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Texture2D(int width, int height)
          : this(width, height, TextureFormat.RGBA32, true, false, IntPtr.Zero)
        {
        }
        //public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) { throw new NotImplementedException(); }
        //public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { throw new NotImplementedException(); }
        //public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { throw new NotImplementedException(); }
        public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
        {
            throw new NotImplementedException();
        }

        public void Apply(bool updateMipmaps)
        {
            this.Apply(updateMipmaps, false);
        }

        public void Apply()
        {
            this.Apply(true, false);
        }
        public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
        {
            throw new NotImplementedException();
        }

        public void Compress(bool highQuality)
        {
            throw new NotImplementedException();
        }
    }
}
