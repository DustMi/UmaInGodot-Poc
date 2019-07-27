using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class HumanDescription
    {
        public HumanBone[] human;
        public float upperArmTwist;
        public float lowerArmTwist;
        public float upperLegTwist;
        public float lowerLegTwist;
        public float armStretch;
        public float legStretch;
        public float feetSpacing;
        public bool hasTranslationDoF;
        public SkeletonBone[] skeleton;
        internal float m_ArmTwist;
        internal float m_ForeArmTwist;
        internal float m_UpperLegTwist;
        internal float m_LegTwist;
        internal float m_ArmStretch;
        internal float m_LegStretch;
        internal float m_FeetSpacing;
        internal float m_GlobalScale;
        internal string m_RootMotionBoneName;
        internal bool m_HasTranslationDoF;
        internal bool m_HasExtraRoot;
        internal bool m_SkeletonHasParents;
    }
}
