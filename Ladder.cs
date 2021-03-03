using System;
namespace OOP
{
    internal class Ladder
    {
        Frame f;
        VerticalBar v;
        public Ladder(int width, int height)
        {
            f = new Frame(width, height);
            v = new VerticalBar(height);
            f = new Frame(width, height);
        }
    }
}