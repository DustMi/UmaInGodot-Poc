using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public int layerCount
        {
            get { throw new NotImplementedException(); }
        }

        public int parameterCount { get; }

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

        public Transform GetBoneTransform(HumanBodyBones humanBoneId)
        {
            throw new NotImplementedException();
        }

        public void SetBool(string name, bool value)
        {
            throw new NotImplementedException();
        }
 
        public void SetBool(int id, bool value)
        {
            throw new NotImplementedException();
        }

        public void SetInteger(int id, int value) { throw new NotImplementedException(); }

        public void SetInteger(string name, int value) { throw new NotImplementedException(); }
        public void SetLookAtPosition(Vector3 lookAtPosition) { throw new NotImplementedException(); }
        public void SetLookAtWeight(float weight) { throw new NotImplementedException(); }
        public void SetLookAtWeight(float weight, float bodyWeight) { throw new NotImplementedException(); }
        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { throw new NotImplementedException(); }
        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { throw new NotImplementedException(); }
        public static int StringToHash(string name) { throw new NotImplementedException(); }
        public void Update(float deltaTime) { throw new NotImplementedException();  }

        public void SetFloat(int id, float value) { throw new NotImplementedException(); }

        public void SetFloat(string name, float value, float dampTime, float deltaTime) { throw new NotImplementedException(); }

        public void SetFloat(string name, float value) { throw new NotImplementedException(); }

        public void SetFloat(int id, float value, float dampTime, float deltaTime) { throw new NotImplementedException(); }
        public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
        {
            AnimatorStateInfo info;
            throw new NotImplementedException();
            //this.GetAnimatorStateInfo(layerIndex, StateInfoIndex.CurrentState, out info);
            return info;
        }
    }
}
