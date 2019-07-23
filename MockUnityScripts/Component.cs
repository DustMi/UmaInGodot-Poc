using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Component : Object
    {
        public T GetComponent<T>()
        {
            Type type = typeof(T);
            return (T)Activator.CreateInstance(type);
        }


    }
}
