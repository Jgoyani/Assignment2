using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;
        private int height;

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
            this.height = 1;
        }

        public Rectangle(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;

        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetHeight()
        {
            return height;
        }
        public int SetHeight(int height)
        {
            this.height = height;
            return height;
        }

        public int GetVolume()
        {
            return length * width * height;
        }
    }
}
