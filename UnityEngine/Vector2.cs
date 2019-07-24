using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Vector2
    {
        private Godot.Vector2 gVector2;
        public Vector2(float x, float y)
        {
            gVector2 = new Godot.Vector2(x, y);
        }

        public float x
        {
            get => gVector2.x;
            set => gVector2.x = value;
        }
        public float y
        {
            get => gVector2.y;
            set => gVector2.y = value;
        }
    }
}
