using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public class Rect
    {
        private Rect2 rect;

        public Rect()
        {
            rect = new Rect2(0,0,0,0);
        }

        public Rect(float x, float y, float width, float height)
        {
            rect = new Rect2(x, y, width, height);
        }

        public float height
        {
            get {
                return rect.Size.y;
            }
            set
            {
                throw new NotImplementedException();
            }
            
        }

        public float width
        {
            get
            {
                return rect.Size.x;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float x
        {
            get
            {
                return rect.Position.x;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float y
        {
            get
            {
                return rect.Position.y;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float yMax
        {
            get; set;
        }

        public float xMin
        {
            get; set;
        }

    }
}
