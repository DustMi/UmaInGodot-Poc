using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Material : Godot.ShaderMaterial
    {
        public Shader shader
        {
            set; get;
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
