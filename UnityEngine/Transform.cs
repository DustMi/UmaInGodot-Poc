using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public class Transform : Component, IEnumerable
    {
        public Vector3 position;
        public Vector3 localPosition;
        private Transform internalParent;
        public Quaternion localRotation { get; set; }

        //public GameObject gameObject
        //{
        //    get; set;
        //}

        public Transform Find(string n)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SetParent(object p0, bool p1)
        {
            throw new NotImplementedException();
        }

        public Transform parent
        {
            get
            {
                return this.internalParent;
            }
            set { this.internalParent = value; }
        }

        public Matrix4x4 worldToLocalMatrix
        {
            get
            {
                Matrix4x4 ret;
                this.get_worldToLocalMatrix_Injected(out ret);
                return ret;
            }
        }

        /// <summary>
        ///   <para>Matrix that transforms a point from local space into world space (Read Only).</para>
        /// </summary>
        public Matrix4x4 localToWorldMatrix
        {
            get
            {
                Matrix4x4 ret;
                this.get_localToWorldMatrix_Injected(out ret);
                return ret;
            }
        }

        private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
        {
            throw new NotImplementedException();
        }
        private void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
        {
            throw new NotImplementedException();
        }

        public Quaternion rotation;
        public Vector3 localScale;
        public int childCount;

        public  Transform GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }
}
