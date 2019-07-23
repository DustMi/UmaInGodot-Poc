using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Profiler
    {
        public static void BeginSample(string name, Object targetObject)
        {
            //do nothing
        }
        //
        // Summary:
        //     Begin profiling a piece of code with a custom label.
        //
        // Parameters:
        //   name:
        //     A string to identify the sample in the Profiler window.
        //
        //   targetObject:
        //     An object that provides context to the sample,.

        public static void BeginSample(string name)
        {
            //do nothing
        }

        public static void EndSample()
        {
            //still doing nothing
        }
    }
}
