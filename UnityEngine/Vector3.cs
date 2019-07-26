using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Vector3
    {
        protected Godot.Vector3 gVector3;

        public Vector3()
        {
            gVector3 = new Godot.Vector3();
        }
        
        public Vector3(float x, float y, float z)
        {
            gVector3 = new Godot.Vector3(x, y, z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3 operator *(Vector3 v1, float scaler)
        {
            return new Vector3(v1.x * scaler, v1.y * scaler, v1.z * scaler);
        }

        public float sqrMagnitude { get; }

        public float x
        {
            get => gVector3.x;
            set => gVector3.x = value;
        }
        public float y
        {
            get => gVector3.y;
            set => gVector3.y = value;
        }
        public float z
        {
            get => gVector3.z;
            set => gVector3.z = value;
        }

        public static Vector3 Scale(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public void Scale(Vector3 scale)
        {
            this.x *= scale.x;
            this.y *= scale.y;
            this.z *= scale.z;
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            t = Mathf.Clamp01(t);
            return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
        }

        public static Vector3 zero
        {
            get => new Vector3(0,0,0);
        }
    }
}