using System;

namespace Maya.Drawing
{
    public class Rectangle : IRectangle
    {
        public int _Width { get; set; }
        public int _Height { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }

        public Rectangle(int posX, int posY, int width, int height, ConsoleColor color, char style)
        {
            _Width = width;
            _Height = height;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            Console.ForegroundColor = _Color;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int x = 0; x < _Width; x++) { MayaDrawing.WriteChar(_posX + x, _posY, _Style); } // Left Border
            for (int x = 0; x < _Width; x++) { MayaDrawing.WriteChar(_posX + x, _posY + _Width - 1, _Style); } // Right Border
            for (int y = 0; y < _Height; y++) { MayaDrawing.WriteChar(_posX, _posY + y, _Style); } // Top Border
            for (int y = 0; y < _Height; y++) { MayaDrawing.WriteChar(_posX + _Height - 1, _posY + y, _Style); } // Bottom
        }
    }

    public class RectangleFilled : IRectangle
    {
        public int _Width { get; set; }
        public int _Height { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }

        public RectangleFilled(int posX, int posY, int width, int height, ConsoleColor color, char style)
        {
            _posX = posX;
            _posY = posY;
            _Width = width;
            _Height = height;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            Console.SetCursorPosition(_posX, _posY);
            Console.ForegroundColor = _Color;
            for (int i = 0; i < _Height; i++)
            {
                for (int j = 0; j < _Width; j++)
                {
                    Console.Write(_Style);
                }
                Console.SetCursorPosition(_posX, _posY + i + 1);
            }
        }
    }
}
