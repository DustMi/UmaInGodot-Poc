using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Avatar : Object
    {
        //
        // Summary:
        //     Return true if this avatar is a valid mecanim avatar. It can be a generic avatar
        //     or a human avatar.
        public bool isValid { get; }
        //
        // Summary:
        //     Return true if this avatar is a valid human avatar.
        public bool isHuman { get; }
        //
        // Summary:
        //     Returns the HumanDescription used to create this Avatar.
        //public HumanDescription humanDescription { get; }
    }
}
