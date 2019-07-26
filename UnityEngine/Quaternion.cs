using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public struct Quaternion : IEquatable<Quaternion>
    {
        public static Quaternion identity { get; }

        public bool Equals(Quaternion other)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Quaternion lhs, Quaternion rhs)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Quaternion lhs, Quaternion rhs)
        {
            throw new NotImplementedException();
        }
        public bool Equals(Object other)
        {
            throw new NotImplementedException();
        }
    }
}
