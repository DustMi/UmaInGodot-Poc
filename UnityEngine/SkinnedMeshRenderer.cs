using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public class SkinnedMeshRenderer : Renderer
    {
        public Bounds bounds;
        public bool updateWhenOffscreen;
        public Bounds localBounds;

        public bool enabled
        {
            get; set;
        }

        public Transform rootBone { get; set; }

        public void SetBlendShapeWeight(int index, float value)
        {
            throw new NotImplementedException();
        }
        public Material[] sharedMaterials { get; set; }
        public Mesh sharedMesh { get; set; }
    }
}
