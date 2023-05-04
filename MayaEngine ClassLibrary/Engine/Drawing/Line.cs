using System;
namespace Maya.Drawing
{
    public class LineVertical : ILine
    {
        public int _length { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }
        public LineVertical(int posX, int posY, int length, ConsoleColor color, char style)
        { 
            _length = length;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            Console.ForegroundColor = _Color;

            for (int y = 0; y < _length; y++)
            { MayaDrawing.WriteChar(_posX, _posY + y, _Style); }
            Console.CursorVisible = false;
            return;
        }

    }
    public class LineHorizontal : ILine
    {
        public int _length { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }
        public LineHorizontal(int posX, int posY, int length, ConsoleColor color, char style)
        {
            _length = length;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            Console.ForegroundColor = _Color;
            for (int x = 0; x < _length; x++) { MayaDrawing.WriteChar(_length + x, _posY, _Style); }
        }
    }
    public class LineDiagonal : ILine
    {
        public int _Width { get; set; }
        public int _Height { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }
        public int _Length { get; set; }
        public bool _isLeftToRight { get; set; }
        public LineDiagonal(int posY, int posX, int length, bool isLeftToRight, ConsoleColor color, char diagonalChar)
        {
            _Width = length;
            _Height = length;
            _Length = length;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = diagonalChar;
            _isLeftToRight = isLeftToRight;
        }
        public void Draw()
        {
            int startX = 0;
            int startY = _Length;
            int endX = _Length - 1;
            int endY = 0;
            Console.ForegroundColor = _Color;
            for (int y = startY; y >= endY; y--)
            {
                for (int x = _isLeftToRight ? startX : endX; _isLeftToRight ? x <= endX : x >= startX; x += _isLeftToRight ? 1 : -1)
                {
                    if ((_isLeftToRight && x - startX == startY - y) || (!_isLeftToRight && startX - x == startY - y))
                    {
                        MayaDrawing.WriteChar(_posX + x, _posY + y,  _Style);
                    }
                }
            }
            Console.SetCursorPosition(0, endY + 1);
        }
    }
}
