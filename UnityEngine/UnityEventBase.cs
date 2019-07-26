using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class UnityEventBase 
    {
        protected void AddListener(object targetObj, MethodInfo method)
        {
            throw new NotImplementedException();
        }
        public static MethodInfo GetValidMethodInfo(object obj, string functionName, System.Type[] argumentTypes)
        {
            for (System.Type type = obj.GetType(); type != typeof(object) && type != null; type = type.BaseType)
            {
                MethodInfo method = type.GetMethod(functionName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder)null, argumentTypes, (ParameterModifier[])null);
                if (method != null)
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    bool flag = true;
                    int index = 0;
                    foreach (ParameterInfo parameterInfo in parameters)
                    {
                        flag = argumentTypes[index].IsPrimitive == parameterInfo.ParameterType.IsPrimitive;
                        if (flag)
                            ++index;
                        else
                            break;
                    }
                    if (flag)
                        return method;
                }
            }
            return (MethodInfo)null;
        }
        public UnityEngine.Object GetPersistentTarget(int index)
        {
            throw new NotImplementedException();
        }
        public string GetPersistentMethodName(int index)
        {
            throw new NotImplementedException();
        }
        public int GetPersistentEventCount()
        {
            throw new NotImplementedException();
        }

    }
}
