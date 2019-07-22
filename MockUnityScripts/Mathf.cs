using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public static class Mathf
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

        public static float Round (float f)
        {
            var toDouble = System.Convert.ToDouble(f);
            toDouble = Math.Round(toDouble);
            return (float)toDouble;
        }
    }
}
