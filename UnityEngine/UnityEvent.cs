using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace UnityEngine
{
    public class UnityEvent<T, U, V, W> : UnityEventBase
        {
            public UnityEvent()
            {

            }

            UnityAction<T, U, V, W> theCall;
            public void AddListener(UnityAction<T, U, V, W> call)
            {
                theCall = call;
            }

            public void Invoke(T arg)
            {
                var nothing = theCall.ToString();
            }

            public void RemoveListener(UnityAction<T, U, V, W> call)
            {
                var nothing = call.ToString();
            }

            public void RemoveListener(object targetObj, MethodInfo method)
            {

            }
        }

    public class UnityEvent<T,U> : UnityEventBase
    {
        public UnityEvent() {

        }

        UnityAction<T, U> theCall;
        public void AddListener(UnityAction<T, U> call)
        {
            theCall = call;
        }

        public void Invoke(T arg)
        {
            var nothing = theCall.ToString();
        }

        public void RemoveListener(UnityAction<T, U> call)
        {
            var nothing = call.ToString();
        }

        public void RemoveListener(object targetObj, MethodInfo method)
        {

        }
    }

    public class UnityEvent<T> : UnityEventBase
    {
        public UnityEvent()
        {

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
