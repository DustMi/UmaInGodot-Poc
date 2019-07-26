using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Material : Object
    {
        public Color color;
        public int renderQueue;
        protected Godot.Shader realShader;
        public Shader shader
        {
            set; get;
        }

        public bool HasProperty(int nameID)
        {
            throw new NotImplementedException();
        }
        public bool HasProperty(string name)
        {
            throw new NotImplementedException();
        }
        public Material(Shader shad)
        {
            throw new NotImplementedException();
        }

        public Material(Material mat)
        {
            throw new NotImplementedException();
        }

    }
}
