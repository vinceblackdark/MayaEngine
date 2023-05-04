using System;

namespace Maya.Drawing
{
    public class Circle : ICircle
    {
        public char _circleChar { get; set; }
        public int _radius { get; set; }
        public ConsoleColor _Color { get; set; }
        public int _posX { get; set; }
        public int _posY { get; set; }
        public Circle(int posX,int posY, int radius, ConsoleColor color, char circleChar)
        {
            _posY = posY;
            _posX = posX;
            _Color = color;
            _radius = radius;
            _circleChar = circleChar;
        }
        public void Draw()
        {
            for (int y = -_radius; y <= _radius; y++)
            {
                for (int x = -_radius; x <= _radius; x++)
                {
                    double distance = Math.Sqrt(x * x + (y * 2) * (y * 2));
                    if (distance <= _radius)
                    {
                        Console.ForegroundColor = _Color;
                        Console.BackgroundColor = ConsoleColor.Black;
                        MayaDrawing.WriteChar(_posX + x, _posY + y / 3 - 1, _circleChar);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        MayaDrawing.WriteChar(_posX, _posY, ' ');
                    }
                }
            }
        }
    }
    public class Oval : ICircle
    {
        public int _Radius { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }

        public int _WindowWidth = Console.WindowWidth;
        public int _WndowHeight = Console.WindowHeight;
        public bool _ShowCursor = Console.CursorVisible = false;
        public Oval(int posX, int posY, int radius, ConsoleColor Color, char Style)
        {
            _Radius = radius;
            _Color = Color;
            _Style = Style;
            _posY = posY;
            _posX = posX;
        }
        public void Draw()
        {
            for (int y = -_Radius; y <= _Radius; y++)
            {
                for (int x = -_Radius; x <= _Radius; x++)
                {
                    double distance = Math.Sqrt(x * x + (y * 2) * (y * 2));
                    if (distance <= _Radius)
                    {
                        Console.ForegroundColor = _Color;

                        MayaDrawing.WriteChar(_posX + x, _posY + y, _Style);
                    }
                    else
                    {
                        MayaDrawing.WriteChar(_posX, _posY, ' ');
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
