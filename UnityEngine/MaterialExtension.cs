using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public static class MaterialExtension
    {
        public static void SetColor(this Material mat, string name, Color c)
        {
            throw new NotImplementedException();
        }

        public static void SetTexture(this Material mat, string name, Texture texture ) {
            throw new NotImplementedException();
        }

        public static void SetTexture(this Material mat, string name, Texture[] texture)
        {
            throw new NotImplementedException();
        }
    }
}
