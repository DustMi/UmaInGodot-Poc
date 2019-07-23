using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    interface ISerializationCallbackReceiver
    {
        void OnAfterDeserialize();
        //
        // Summary:
        //     Implement this method to receive a callback before Unity serializes your object.
        void OnBeforeSerialize();
    }
}
