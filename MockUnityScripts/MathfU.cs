using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUnityScripts
{
    public static class MathfU
    {
        private static float Epsilon = 0.0001f;
        public static bool Approximately(float a, float b)
        {
            if (a >= b - Epsilon && a <= b + Epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
