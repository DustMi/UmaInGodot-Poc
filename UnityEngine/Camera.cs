using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Camera : Behaviour
    {
        public Color backgroundColor { get; set; }
        public static Camera main { get; }
        public float orthographicSize { get; set; }
        public void Render()
        {
            throw new NotImplementedException();
        }
        public RenderTexture targetTexture { get; set; }
    }
}
