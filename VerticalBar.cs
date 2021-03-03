using System;
namespace OOP
{
    internal class VerticalBar
    {
        private int height;
        public VerticalBar(int height)
        {
            this.height = height;

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine($"|");
            }
        }
    }
}