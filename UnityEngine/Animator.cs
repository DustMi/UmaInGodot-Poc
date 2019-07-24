using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Animator : Behaviour
    {
        public Avatar avatar { get; set; }

        public bool GetBool(string name)
        {
            throw new NotImplementedException();
        }

        public bool GetBool(int id)
        {
            throw new NotImplementedException();
        }

        public AnimatorStateInfo GetCurrentAnimatorStateInfo()
        {
            throw new NotImplementedException();
        }

        public float GetFloat(string name)
        {
            throw new NotImplementedException();
        }

        public float GetFloat(int id)
        {
            throw new NotImplementedException();
        }

        public int GetInteger(string name)
        {
            throw new NotImplementedException();
        }

        public int GetInteger(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsParameterControlledByCurve(string name)
        {
            throw new NotImplementedException();
        }

        public bool IsParameterControlledByCurve(int id)
        {
            throw new NotImplementedException();
        }

        public int layerCount()
        {
            throw new NotImplementedException();
        }

        public int parameterCount()
        {
            throw new NotImplementedException();
        }

        public AnimatorControllerParameter[] parameters
        {
            get;
        }

        public void Play(string stateName, int layer = -1, float normalizedTime = float.NegativeInfinity)
        {
            throw new NotImplementedException();
        }
        public void Play(int stateNameHash, int layer = -1, float normalizedTime = float.NegativeInfinity)
        {
            throw new NotImplementedException();
        }

        public RuntimeAnimatorController runtimeAnimatorController
        {
            get; set;
        }
    }
}
