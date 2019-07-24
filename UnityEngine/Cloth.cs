using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Cloth
    {
        public float stretchingStiffness;
        public float sleepThreshold;
        public float friction;
        public float damping;
        public float collisionMassScale;
        public float bendingStiffness;
        public bool useGravity;
        public float useVirtualParticles;
        public Vector3 externalAcceleration;
        public Vector3 randomAcceleration;
        public float worldAccelerationScale;
        public float worldVelocityScale;
    }
}
