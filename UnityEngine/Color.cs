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

        public float a
        {
            get => realColor.a;
            set => realColor.a = value;
        }
        public float r
        {
            get => realColor.r;
            set => realColor.r = value;
        }
        public float g
        {
            get => realColor.g;
            set => realColor.g = value;
        }
        public float b
        {
            get => realColor.b;
            set => realColor.b = value;
        }

        public Color()
        {
            
        }

        public Color(string webStyle)
        {
            realColor = new Godot.Color(webStyle);
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

        public static Color white => new Color(1.0f, 1.0f, 1.0f, 1.0f);

        public static Color ColorN(string webStyle)
        {
            return new Color(webStyle);
        }
    }
}
