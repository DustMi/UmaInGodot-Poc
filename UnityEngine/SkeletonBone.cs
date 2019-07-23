using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public class SkeletonBone
    {
        public string name
        {
            get; set;
        }

        public Vector3 position
        {
            get; set;
        }

        public Quaternion rotation
        {
            get; set;
        }

        public Vector3 scale
        {
            get; set;
        }
    }
}
