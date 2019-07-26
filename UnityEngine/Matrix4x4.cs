using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Matrix4x4
    {
        private static readonly Matrix4x4 zeroMatrix = new Matrix4x4(new Vector4(0.0f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
        private static readonly Matrix4x4 identityMatrix = new Matrix4x4(new Vector4(1f, 0.0f, 0.0f, 0.0f), new Vector4(0.0f, 1f, 0.0f, 0.0f), new Vector4(0.0f, 0.0f, 1f, 0.0f), new Vector4(0.0f, 0.0f, 0.0f, 1f));
        [NativeName("m_Data[0]")]
        public float m00;
        [NativeName("m_Data[1]")]
        public float m10;
        [NativeName("m_Data[2]")]
        public float m20;
        [NativeName("m_Data[3]")]
        public float m30;
        [NativeName("m_Data[4]")]
        public float m01;
        [NativeName("m_Data[5]")]
        public float m11;
        [NativeName("m_Data[6]")]
        public float m21;
        [NativeName("m_Data[7]")]
        public float m31;
        [NativeName("m_Data[8]")]
        public float m02;
        [NativeName("m_Data[9]")]
        public float m12;
        [NativeName("m_Data[10]")]
        public float m22;
        [NativeName("m_Data[11]")]
        public float m32;
        [NativeName("m_Data[12]")]
        public float m03;
        [NativeName("m_Data[13]")]
        public float m13;
        [NativeName("m_Data[14]")]
        public float m23;
        [NativeName("m_Data[15]")]
        public float m33;
        public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
        {
            this.m00 = column0.x;
            this.m01 = column1.x;
            this.m02 = column2.x;
            this.m03 = column3.x;
            this.m10 = column0.y;
            this.m11 = column1.y;
            this.m12 = column2.y;
            this.m13 = column3.y;
            this.m20 = column0.z;
            this.m21 = column1.z;
            this.m22 = column2.z;
            this.m23 = column3.z;
            this.m30 = column0.w;
            this.m31 = column1.w;
            this.m32 = column2.w;
            this.m33 = column3.w;
        }
        public Vector3 MultiplyPoint(Vector3 point)
        {
            Vector3 vector3 = new Vector3();
            vector3.x = (float)((double)this.m00 * (double)point.x + (double)this.m01 * (double)point.y + (double)this.m02 * (double)point.z) + this.m03;
            vector3.y = (float)((double)this.m10 * (double)point.x + (double)this.m11 * (double)point.y + (double)this.m12 * (double)point.z) + this.m13;
            vector3.z = (float)((double)this.m20 * (double)point.x + (double)this.m21 * (double)point.y + (double)this.m22 * (double)point.z) + this.m23;
            float num = 1f / ((float)((double)this.m30 * (double)point.x + (double)this.m31 * (double)point.y + (double)this.m32 * (double)point.z) + this.m33);
            vector3.x *= num;
            vector3.y *= num;
            vector3.z *= num;
            return vector3;
        }
    }
}
