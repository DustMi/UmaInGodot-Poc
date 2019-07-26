using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public static class Time
    {
        public static int frameCount;
        public static float deltaTime;
        static DateTime startTime;
        static Time()
        {
            startTime = DateTime.Now;
        }

    }
}
