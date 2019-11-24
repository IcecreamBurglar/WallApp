﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallApp
{
    public class RectangleF
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public float Top { get => Y; }
        public float Right { get => X + Width; }
        public float Bottom { get => Y + Height; }
        public float Left { get => X; }

        public RectangleF(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public bool Contains(Vector2 position)
        {
            return (position.X >= X && X + Width >= position.X) && (position.Y >= Y && Y + Height >= position.Y);
        }
    }
}