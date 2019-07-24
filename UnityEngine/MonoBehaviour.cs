using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public class MonoBehaviour : Behaviour
    {
        public Transform transform;
        public GameObject gameObject
        {
            get; set;
        }

        public Task StartCoroutine(string methodName)
        {
            return null;
        }
        //
        // Summary:
        //     Starts a coroutine.
        //
        // Parameters:
        //   routine:
        public Task StartCoroutine(IEnumerator routine)
        {
            return null;
        }

        public void StopCoroutine(string methodName)
        {
            //do nothing
        }

    }
}
