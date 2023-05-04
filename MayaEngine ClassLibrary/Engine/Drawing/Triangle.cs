using System;

namespace Maya.Drawing
{
    public class Triangle : ITriangle
    {
        public int _Height { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public Triangle(int posX, int posY, int height, ConsoleColor color, char styleFilled)
        {
            _Height = height;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = styleFilled;
        }
        public void Draw()
        {
            Console.ForegroundColor = _Color;
            Console.BackgroundColor = ConsoleColor.Black;

            for (int i = 1; i <= _Height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    MayaDrawing.WriteChar(_posX + i + 1, _posY + j, _Style);
                }
            }
        }
    }
}
