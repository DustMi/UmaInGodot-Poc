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
        public T GetComponentInParent<T>()
        {
            throw new NotImplementedException();
        }
        public GameObject(string name)
        {
            throw new NotImplementedException();
        }

        public GameObject(string name, params Type[] components)
        {
            throw new NotImplementedException();
        }

        public bool activeInHierarchy {
            get;
        }
        public bool activeSelf
        {
            get;
            private set;
        }

        public void SetActive(bool a)
        {
            this.active = a;
        }

        public Transform transform
        {
            get;
        }

        public T GetComponent<T>()
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }

        public T AddComponent<T>() where T : Component
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }

        public T AddComponent<T>(T component)
        {
            return (T)component;
        }

        internal T GetComponentInChildren<T>()
        {
            throw new NotImplementedException();
        }

        public static GameObject Find(string name)
        {
            throw new NotImplementedException();
        }

    }
}
