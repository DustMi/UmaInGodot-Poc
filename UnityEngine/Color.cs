using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Color
    {
        protected Godot.Color realColor;

        public Color()
        {
            
        }

        public Color(int r, int g, int b)
        {
            realColor = new Godot.Color(r, g, b);
        }

        public Color(int color)
        {
            realColor = new Godot.Color(color);
        }

        public Color(float r, float g, float b, float alpha)
        {

        }

        public static Color white
        {
            get
            {
                return new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }
    }
}
