// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector4
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2094A731-351D-475D-BA68-F5920DE30ED8
// Assembly location: C:\Local\personal\Unity\2019.1.11f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Globalization;


namespace UnityEngine
{

    public struct Vector4 : IEquatable<Vector4>
    {
        private static readonly Vector4 zeroVector = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
        private static readonly Vector4 oneVector = new Vector4(1f, 1f, 1f, 1f);
        private static readonly Vector4 positiveInfinityVector = new Vector4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        private static readonly Vector4 negativeInfinityVector = new Vector4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        public const float kEpsilon = 1E-05f;
        /// <summary>
        ///   <para>X component of the vector.</para>
        /// </summary>
        public float x;
        /// <summary>
        ///   <para>Y component of the vector.</para>
        /// </summary>
        public float y;
        /// <summary>
        ///   <para>Z component of the vector.</para>
        /// </summary>
        public float z;
        /// <summary>
        ///   <para>W component of the vector.</para>
        /// </summary>
        public float w;

        /// <summary>
        ///   <para>Creates a new vector with given x, y, z, w components.</para>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        ///   <para>Creates a new vector with given x, y, z components and sets w to zero.</para>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Vector4(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 0.0f;
        }

        /// <summary>
        ///   <para>Creates a new vector with given x, y components and sets z and w to zero.</para>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector4(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.z = 0.0f;
            this.w = 0.0f;
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.x;
                    case 1:
                        return this.y;
                    case 2:
                        return this.z;
                    case 3:
                        return this.w;
                    default:
                        throw new IndexOutOfRangeException("Invalid Vector4 index!");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.x = value;
                        break;
                    case 1:
                        this.y = value;
                        break;
                    case 2:
                        this.z = value;
                        break;
                    case 3:
                        this.w = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid Vector4 index!");
                }
            }
        }

        /// <summary>
        ///   <para>Set x, y, z and w components of an existing Vector4.</para>
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="newZ"></param>
        /// <param name="newW"></param>
        public void Set(float newX, float newY, float newZ, float newW)
        {
            this.x = newX;
            this.y = newY;
            this.z = newZ;
            this.w = newW;
        }

        /// <summary>
        ///   <para>Linearly interpolates between two vectors.</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            t = Mathf.Clamp01(t);
            return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
        }

        /// <summary>
        ///   <para>Linearly interpolates between two vectors.</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
        {
            return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
        }

        /// <summary>
        ///   <para>Moves a point current towards target.</para>
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
        {
            float num1 = target.x - current.x;
            float num2 = target.y - current.y;
            float num3 = target.z - current.z;
            float num4 = target.w - current.w;
            float num5 = (float)((double)num1 * (double)num1 + (double)num2 * (double)num2 + (double)num3 * (double)num3 + (double)num4 * (double)num4);
            if ((double)num5 == 0.0 || (double)maxDistanceDelta >= 0.0 && (double)num5 <= (double)maxDistanceDelta * (double)maxDistanceDelta)
                return target;
            float num6 = (float)Math.Sqrt((double)num5);
            return new Vector4(current.x + num1 / num6 * maxDistanceDelta, current.y + num2 / num6 * maxDistanceDelta, current.z + num3 / num6 * maxDistanceDelta, current.w + num4 / num6 * maxDistanceDelta);
        }

        /// <summary>
        ///   <para>Multiplies two vectors component-wise.</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static Vector4 Scale(Vector4 a, Vector4 b)
        {
            return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }

        /// <summary>
        ///   <para>Multiplies every component of this vector by the same component of scale.</para>
        /// </summary>
        /// <param name="scale"></param>
        public void Scale(Vector4 scale)
        {
            this.x *= scale.x;
            this.y *= scale.y;
            this.z *= scale.z;
            this.w *= scale.w;
        }

        public override int GetHashCode()
        {
            return this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2 ^ this.w.GetHashCode() >> 1;
        }

        /// <summary>
        ///   <para>Returns true if the given vector is exactly equal to this vector.</para>
        /// </summary>
        /// <param name="other"></param>
        public override bool Equals(object other)
        {
            if (!(other is Vector4))
                return false;
            return this.Equals((Vector4)other);
        }

        public bool Equals(Vector4 other)
        {
            return (double)this.x == (double)other.x && (double)this.y == (double)other.y && (double)this.z == (double)other.z && (double)this.w == (double)other.w;
        }

        /// <summary>
        ///   <para></para>
        /// </summary>
        /// <param name="a"></param>
        public static Vector4 Normalize(Vector4 a)
        {
            float num = Vector4.Magnitude(a);
            if ((double)num > 9.99999974737875E-06)
                return a / num;
            return Vector4.zero;
        }

        /// <summary>
        ///   <para>Makes this vector have a magnitude of 1.</para>
        /// </summary>
        public void Normalize()
        {
            float num = Vector4.Magnitude(this);
            if ((double)num > 9.99999974737875E-06)
                this = this / num;
            else
                this = Vector4.zero;
        }

        /// <summary>
        ///   <para>Returns this vector with a magnitude of 1 (Read Only).</para>
        /// </summary>
        public Vector4 normalized
        {
            get
            {
                return Vector4.Normalize(this);
            }
        }

        /// <summary>
        ///   <para>Dot Product of two vectors.</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static float Dot(Vector4 a, Vector4 b)
        {
            return (float)((double)a.x * (double)b.x + (double)a.y * (double)b.y + (double)a.z * (double)b.z + (double)a.w * (double)b.w);
        }

        /// <summary>
        ///   <para>Projects a vector onto another vector.</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static Vector4 Project(Vector4 a, Vector4 b)
        {
            return b * (Vector4.Dot(a, b) / Vector4.Dot(b, b));
        }

        /// <summary>
        ///   <para>Returns the distance between a and b.</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static float Distance(Vector4 a, Vector4 b)
        {
            return Vector4.Magnitude(a - b);
        }

        public static float Magnitude(Vector4 a)
        {
            return (float)Math.Sqrt((double)Vector4.Dot(a, a));
        }

        /// <summary>
        ///   <para>Returns the length of this vector (Read Only).</para>
        /// </summary>
        public float magnitude
        {
            get
            {
                return (float)Math.Sqrt((double)Vector4.Dot(this, this));
            }
        }

        /// <summary>
        ///   <para>Returns the squared length of this vector (Read Only).</para>
        /// </summary>
        public float sqrMagnitude
        {
            get
            {
                return Vector4.Dot(this, this);
            }
        }

        

        /// <summary>
        ///   <para>Shorthand for writing Vector4(0,0,0,0).</para>
        /// </summary>
        public static Vector4 zero
        {
            get
            {
                return Vector4.zeroVector;
            }
        }

        /// <summary>
        ///   <para>Shorthand for writing Vector4(1,1,1,1).</para>
        /// </summary>
        public static Vector4 one
        {
            get
            {
                return Vector4.oneVector;
            }
        }

        /// <summary>
        ///   <para>Shorthand for writing Vector4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity).</para>
        /// </summary>
        public static Vector4 positiveInfinity
        {
            get
            {
                return Vector4.positiveInfinityVector;
            }
        }

        /// <summary>
        ///   <para>Shorthand for writing Vector4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity).</para>
        /// </summary>
        public static Vector4 negativeInfinity
        {
            get
            {
                return Vector4.negativeInfinityVector;
            }
        }

        public static Vector4 operator +(Vector4 a, Vector4 b)
        {
            return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }

        public static Vector4 operator -(Vector4 a, Vector4 b)
        {
            return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }

        public static Vector4 operator -(Vector4 a)
        {
            return new Vector4(-a.x, -a.y, -a.z, -a.w);
        }

        public static Vector4 operator *(Vector4 a, float d)
        {
            return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
        }

        public static Vector4 operator *(float d, Vector4 a)
        {
            return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
        }

        public static Vector4 operator /(Vector4 a, float d)
        {
            return new Vector4(a.x / d, a.y / d, a.z / d, a.w / d);
        }

        public static bool operator ==(Vector4 lhs, Vector4 rhs)
        {
            float num1 = lhs.x - rhs.x;
            float num2 = lhs.y - rhs.y;
            float num3 = lhs.z - rhs.z;
            float num4 = lhs.w - rhs.w;
            return (double)num1 * (double)num1 + (double)num2 * (double)num2 + (double)num3 * (double)num3 + (double)num4 * (double)num4 < 9.99999943962493E-11;
        }

        public static bool operator !=(Vector4 lhs, Vector4 rhs)
        {
            return !(lhs == rhs);
        }

        public static implicit operator Vector4(Vector3 v)
        {
            return new Vector4(v.x, v.y, v.z, 0.0f);
        }

        public static implicit operator Vector3(Vector4 v)
        {
            return new Vector3(v.x, v.y, v.z);
        }

        public static implicit operator Vector4(Vector2 v)
        {
            return new Vector4(v.x, v.y, 0.0f, 0.0f);
        }

        public static implicit operator Vector2(Vector4 v)
        {
            return new Vector2(v.x, v.y);
        }

        public static float SqrMagnitude(Vector4 a)
        {
            return Vector4.Dot(a, a);
        }

        public float SqrMagnitude()
        {
            return Vector4.Dot(this, this);
        }
    }
}
