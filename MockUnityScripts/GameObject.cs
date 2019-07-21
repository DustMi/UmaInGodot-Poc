using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class GameObject : Object
    {
        private bool active;
        public bool activeSelf
        {
            get;
            private set;
        }

        public void SetActive(bool a)
        {
            this.active = a;
        }

        public List<Transform> transform
        {
            get;
        }

        public T GetComponent<T>()
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }

        public T AddComponent<T>(T component)
        {
            return (T)component;
        }
    }
}
