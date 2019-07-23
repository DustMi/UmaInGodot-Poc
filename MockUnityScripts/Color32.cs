using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public class Color32
    {
        private Color myColor;
        private byte alpha;
        private byte red;
        private byte green;
        private byte blue;

        public static implicit operator Color32 (Color color)
        {
            return new Color32((byte)color.r8, (byte)color.g8, (byte)color.b8, (byte)color.a8);
        }

        public static implicit operator Color(Color32 color)
        {
            byte[] colorArray = new byte[] { color.a, color.r, color.g, color.b };
            return new Color(BitConverter.ToInt32(colorArray, 0));
        }

        public Color32()
        {
            myColor = new Color(0.0f, 0.0f, 0.0f, 1);
        }

        public Color32(byte r, byte g, byte b, byte a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
            byte[] colorArray = new byte[] { alpha, red, green, blue };
            myColor = new Color(BitConverter.ToInt32(colorArray, 0));
        }

        private void updateBytes()
        {
            int intValue = myColor.ToArgb32();

            byte[] bytes = new byte[4];

            alpha = (byte)(intValue >> 24);
            red = (byte)(intValue >> 16);
            green = (byte)(intValue >> 8);
            blue = (byte)intValue;
        }

        public byte r
        {
            get
            {
                return red;
            }
        }

        public byte g
        {
            get
            {
                return green;
            }
        }

        public byte b
        {
            get
            {
                return blue;
            }
        }

        public byte a
        {
            get
            {
                return alpha;
            }
        }


    }
}
