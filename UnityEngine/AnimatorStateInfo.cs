using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public struct AnimatorStateInfo
    {
        //
        // Summary:
        //     The full path hash for this state.
        public int fullPathHash { get; }
        //
        // Summary:
        //     The hashed name of the State.
        [Obsolete("AnimatorStateInfo.nameHash has been deprecated. Use AnimatorStateInfo.fullPathHash instead.")]
        public int nameHash { get; }
        //
        // Summary:
        //     The hash is generated using Animator.StringToHash. The hash does not include
        //     the name of the parent layer.
        public int shortNameHash { get; }
        //
        // Summary:
        //     Normalized time of the State.
        public float normalizedTime { get; }
        //
        // Summary:
        //     Current duration of the state.
        public float length { get; }
        //
        // Summary:
        //     The playback speed of the animation. 1 is the normal playback speed.
        public float speed { get; }
        //
        // Summary:
        //     The speed multiplier for this state.
        public float speedMultiplier { get; }
        //
        // Summary:
        //     The Tag of the State.
        public int tagHash { get; }
        //
        // Summary:
        //     Is the state looping.
        public bool loop { get; }

        //
        // Summary:
        //     Does name match the name of the active state in the statemachine?
        //
        // Parameters:
        //   name:
        //public bool IsName(string name);
        //
        // Summary:
        //     Does tag match the tag of the active state in the statemachine.
        //
        // Parameters:
        //   tag:
        //public bool IsTag(string tag);
    }
}
