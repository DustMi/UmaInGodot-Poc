using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class AnimationCurve
    {
        public Keyframe[] keys;

        public AnimationCurve(params Keyframe[] ks)
        {
            keys = ks;
        }

        public float Evaluate(float time)
        {
            throw new NotImplementedException();
        }
    }
}
