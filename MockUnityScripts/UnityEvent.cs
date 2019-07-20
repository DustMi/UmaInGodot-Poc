using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MockUnityScripts
{
    public class UnityEvent<T>
    {
        public UnityEvent() {

        }

        UnityAction<T> theCall;
        public void AddListener(UnityAction<T> call)
        {
            theCall = call;
        }

        public void Invoke(T arg)
        {
            var nothing = theCall.ToString();
        }

        public void RemoveListener(UnityAction<T> call)
        {
            var nothing = call.ToString();
        }

        public void RemoveListener(object targetObj, MethodInfo method)
        {

        }
    }
}
