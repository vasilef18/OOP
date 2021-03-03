using System;
namespace OOP
{
    internal class Frame
    {
        HorizontalBar h1, h2;
        VerticalBar v;
        public Frame(int width , int height)
        {
            h1 = new HorizontalBar(width);
            v = new VerticalBar(height);
            h2 = new HorizontalBar(width);
        }
    }
}