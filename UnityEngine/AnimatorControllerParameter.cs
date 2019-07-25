using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class AnimatorControllerParameter
    {
        public string name { get; set; }

        public int nameHash { get; }

        public AnimatorControllerParameterType type { get; set; }

        public float defaultFloat { get; set; }

        public int defaultInt { get; set; }

        public bool defaultBool { get; set; }
    }
}
