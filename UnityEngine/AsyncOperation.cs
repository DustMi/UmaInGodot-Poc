using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class AsyncOperation : YieldInstruction
    {
        public bool isDone;
        public float progress;
    }
}
