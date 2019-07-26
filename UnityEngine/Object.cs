using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Object
    {
        public int instanceID;
        public string name
        {
            get; set;
        }

        public static implicit operator bool(Object exists)
        {
            return !object.ReferenceEquals(exists, null);
        }

        public static void DontDestroyOnLoad(Object target)
        {
            //doing nothing
        }

        public static Object[] FindObjectsOfType(Type type)
        {
            return new Object[0];
        }

        public static void Destroy(Object obj)
        {
            //doing nothing
        }

        public static T FindObjectOfType<T>() where T : Object
        {
            throw new NotImplementedException();
        }
        private static void CheckNullArgument(object arg, string message)
        {
            if (arg == null)
                throw new ArgumentException(message);
        }

        public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
        {
            if ((Object)parent == (Object)null)
                return Object.Instantiate(original);
            Object.CheckNullArgument((object)original, "The Object you want to instantiate is null.");
            Object @object = Object.Internal_CloneSingleWithParent(original, parent, instantiateInWorldSpace);
            if (@object == (Object)null)
                throw new Exception("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
            return @object;
        }

        public static T Instantiate<T>(T original) where T : Object
        {
            throw new NotImplementedException();
        }

        public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
        {
            return (T)Object.Instantiate((Object)original, position, rotation);
        }

        public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
        {
            return (T)Object.Instantiate((Object)original, position, rotation, parent);
        }

        public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
        {
            return (T)Object.Instantiate((Object)original, parent, worldPositionStays);
        }

        private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays)
        {
            throw new NotImplementedException();
        }

        public int GetInstanceID()
        {
            return this.instanceID;
        }
    }
}
