using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Keyframe
    {
        public float inTangent
        {
            get; set;
        }

        public float outTangent
        {
            get; set;
        }

        public float value
        {
            get; set;
        }

        public float time
        {
            get; set;
        }

        public Keyframe(float time, float value)
        {
            throw new NotImplementedException();
        }

        public Keyframe(float time, float value, float inTangent, float outTangent)
        {
            throw new NotImplementedException();
        }
    }
}
