using System;
using System.Threading;

namespace Maya.Drawing
{
    public class Point : IPoint
    {
        private int _lastPosY;
        private int _lastPosX;

        private static int _bulletX;
        private static int _bulletY;

        public int _posY { get; set; }
        public int _posX { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _Style { get; set; }
        private bool _isLastPosition;
        public bool _ShowCursor = Console.CursorVisible = false;
        public Point(int posX, int posY, ConsoleColor color, char style)
        {
            _Color = color;
            _Style = style;
            _posY = posY;
            _posX = posX;
            _bulletX = posX;
        }
        public void Draw()
        {
            Console.ForegroundColor = _Color;
            MayaDrawing.WriteChar(_posX, _posY, _Style);
            Console.CursorVisible = false;
        }
        public void Move(string direction)
        {
            Thread A = new Thread(() =>
            {
                int steps = 1;
                _isLastPosition = true;

                _lastPosX = _posX;
                _lastPosY = _posY;

                switch (direction)
                {
                    case "left":
                        if (_posX <= 3) { return; }
                        else
                        {
                            _posX -= steps;
                            break;
                        }
                    case "right":
                        if (_posX >= Console.WindowWidth - 4) { return; }
                        else
                        {
                            _posX += steps;
                            break;
                        }
                    case "down":
                        if (_posY >= Console.WindowHeight - 2) { return; }
                        else
                        {
                            _posY += steps;
                            break;
                        }
                    case "up":
                        if (_posY <= 2) { return; }
                        else
                        {
                            _posY -= steps;
                            break;
                        }
                    default: break;
                }
                Console.ForegroundColor = _Color;
                MayaDrawing.WriteChar(_posX, _posY, _Style);
                MayaDrawing.WriteChar(_lastPosX, _lastPosY, Sprites._charShadowLow);
                MayaDrawing.WriteChar(_lastPosX++, _lastPosY++, Sprites._charEmpty);

                Console.CursorVisible = false;
            }); A.Start(); A.Join();
        }
        public void Shoot()
        {
            _bulletY = _posY;
            _bulletX = _posX;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread A = new Thread(() =>
            {
                while (true)
                {
                    _bulletY -= 1;
                    if (_bulletY <= 4)
                    {
                        Console.SetBufferSize(Console.BufferWidth++, Console.BufferHeight++);
                        _bulletY -= 0;
                    }
                    Console.SetCursorPosition(_bulletX, _bulletY);
                    Console.Write("|");

                    Thread.Sleep(20);

                    Console.SetCursorPosition(_bulletX, _bulletY);
                    Console.Write(" ");
                }
            }); A.Start();
            Thread.Sleep(20);
        }
    }
}
