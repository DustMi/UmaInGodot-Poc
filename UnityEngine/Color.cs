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

        public int a8 => realColor.a8;
        public int r8 => realColor.r8;
        public int g8 => realColor.g8;
        public int b8 => realColor.b8;
       
        public Color gamma
        {
            get
            {
                return this;
            }
        }


        public Color()
        {
            
        }

        protected Color(Godot.Color c)
        {
            realColor = c;
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
        public static Color grey
        {
            get
            {
                return new Color(Godot.Color.ColorN("gray"));
            }
        }

        public int ToArgb32()
        {
            return realColor.ToAbgr32();
        }

    }
}
