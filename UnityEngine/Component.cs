using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Component : Object
    {
        public GameObject gameObject { get; }
        public extern Component GetComponent(string type);
        public T GetComponent<T>()
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }
        public Transform transform { get; }

    }
}
