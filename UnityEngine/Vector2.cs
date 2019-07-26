using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Vector2
    {
        protected Godot.Vector2 gVector2;
        public void Set(float newX, float newY)
        {
            gVector2.x = newX;
            gVector2.y = newY;
        }
        public Vector2(float x, float y)
        {
            gVector2 = new Godot.Vector2(x, y);
        }

        protected Vector2(Godot.Vector2 v)
        {
            gVector2 = v;
        }

        public static Vector2 operator *(Vector2 v, float scaler)
        {
            v.x *= scaler;
            v.y *= scaler;
            return v;
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
