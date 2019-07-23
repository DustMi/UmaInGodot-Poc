using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{ 
    public class Mesh : Object
    {
        public int blendShapeCount { get; }
        public int GetBlendShapeIndex(string blendShapeName)
        {
            throw new NotImplementedException();
        }

        public string GetBlendShapeName(int shapeIndex)
        {
            throw new NotImplementedException();
        }
    }
}
