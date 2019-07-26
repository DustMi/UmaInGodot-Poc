using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class BoneWeight
    {
        public float weight0 { get; set; }
        //
        // Summary:
        //     Skinning weight for second bone.
        public float weight1 { get; set; }
        //
        // Summary:
        //     Skinning weight for third bone.
        public float weight2 { get; set; }
        //
        // Summary:
        //     Skinning weight for fourth bone.
        public float weight3 { get; set; }
        //
        // Summary:
        //     Index of first bone.
        public int boneIndex0 { get; set; }
        //
        // Summary:
        //     Index of second bone.
        public int boneIndex1 { get; set; }
        //
        // Summary:
        //     Index of third bone.
        public int boneIndex2 { get; set; }
        //
        // Summary:
        //     Index of fourth bone.
        public int boneIndex3 { get; set; }
    }
}
