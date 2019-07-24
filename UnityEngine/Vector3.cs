using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Vector3
    {
        private Godot.Vector3 gVector3;

        public Vector3(float x, float y, float z)
        {
            gVector3 = new Godot.Vector3(x, y, z);
        }

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
    }
}