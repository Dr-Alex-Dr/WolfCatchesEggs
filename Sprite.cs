using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    internal class Sprite
    {
        private int v1;
        private int v2;
        private Resources resources;
        private double v3;

        public int X { get; }
        public int Y { get; }
        public Bitmap Picture { get; }

        public Sprite(int x, int y, Bitmap picture)
        {
            X = x;
            Y = y;
            Picture = picture;
        }

        public Sprite(int v1, int v2, Resources resources, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.resources = resources;
            this.v3 = v3;
        }
    }
}
