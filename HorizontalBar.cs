using System;
namespace OOP
{
    internal class HorizontalBar
    {
        private int width;
        public HorizontalBar(int width)
        {
            this.width = width;
            for (int i = 0; i < width; i++)
            {
                Console.Write("~");
            }
            Console.WriteLine();
        }
    }
}