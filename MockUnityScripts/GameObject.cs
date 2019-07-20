using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUnityScripts
{
    public class GameObject
    {
        public string name
        {
            get; set;
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
