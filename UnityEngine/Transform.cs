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
        public object localRotation;

        public GameObject gameObject
        {
            get; set;
        }

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
    }
}
