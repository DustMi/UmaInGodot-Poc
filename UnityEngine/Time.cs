using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public static class Time
    {
        static DateTime startTime;
        static Time()
        {
            startTime = DateTime.Now;
        }

    }
}
