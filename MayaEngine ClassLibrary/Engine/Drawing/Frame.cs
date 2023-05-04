using System;

namespace Maya.Drawing
{
    public class Frame : IFrame
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor _Color { get; set; }
        public char _FrameChar { get; set; }
        public Frame( int width, int height, ConsoleColor color, char FrameChar)
        {
            Width = width;
            Height = height;
            _Color = color;
            _FrameChar = FrameChar;
            Width -= 1;
            Height -= 1;
        }
        public void Draw()
        {
            Console.ForegroundColor = _Color;
            // Left Border
            for (int x = 1; x < Height; x++) { CharToPosition(Width, x, _FrameChar); }
            // Right Border
            for (int x = 1; x < Height; x++) { CharToPosition(1, x, _FrameChar); }
            // Top Border
            for (int y = 1; y < Width; y++) { CharToPosition(y, 1, _FrameChar); }
            // Bottom Border
            for (int y = 1; y < Width; y++) { CharToPosition(y, Height, _FrameChar); }
            // Corner Top Right
            CharToPosition(1, 1, _FrameChar);
            // Corner Top Left
            CharToPosition(Width, 1, _FrameChar);
            // Corner Bottom Left
            CharToPosition(1, Height, _FrameChar);
            // Corber Bottom Right
        }
        static void CharToPosition(int posY, int posX, char Char)
        {
            if (posX <= 0 || posY <= 0) { return; }
            if (posY >= Console.WindowWidth || posX >= Console.WindowHeight) { return; }

            Console.SetCursorPosition(posY, posX);
            Console.Write(Char);
            Console.CursorVisible = false;
        }
    }
    public class FrameStyle : IFrame
        {
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor _Color { get; set; }
        public string _borderStyle { get; set; }
        public FrameStyle(int width, int height, ConsoleColor color, string BorderStyle)
        {
             Width = width;
             Height = height;
            _Color = color;
            _borderStyle = BorderStyle;
            Width -= 1;
            Height -= 1;
        }
        public void Draw()
        { 
            Console.ForegroundColor = _Color;

            char[] getChars = GetCharArray(_borderStyle);
            char _charWidth = getChars[0];
            char _charHeight = getChars[1];
            char _cornerTopRight = getChars[2];
            char _cornerTopLeft = getChars[3];
            char _cornerBottomLeft = getChars[4];
            char _cornerBottomRight = getChars[5];
            // Left Border
            for (int x = 1; x < Height; x++) { CharToPosition(Width, x, _charHeight); }
            // Right Border
            for (int x = 1; x < Height; x++) { CharToPosition(1, x, _charHeight); }
            // Top Border
            for (int y = 1; y < Width; y++) { CharToPosition(y, 1, _charWidth); }
            // Bottom Border
            for (int y = 1; y < Width; y++) { CharToPosition(y, Height, _charWidth); }
            // Corner Top Right
            CharToPosition(1, 1, _cornerTopRight);
            // Corner Top Left
            CharToPosition(Width, 1, _cornerTopLeft);
            // Corner Bottom Left
            CharToPosition(1, Height, _cornerBottomLeft);
            // Corber Bottom Right
            CharToPosition(Width, Height, _cornerBottomRight);
        }
        static char[] GetCharArray(string BorderStyle)
        {
            char[] charArray = new char[6];
            switch (BorderStyle.ToString())
            {
                case "bolt":
                    charArray[0] = Sprites._charHeightBolt;
                    charArray[1] = Sprites._charHeightBolt;
                    charArray[2] = Sprites._charHeightBolt;
                    charArray[3] = Sprites._charHeightBolt;
                    charArray[4] = Sprites._charHeightBolt;
                    charArray[5] = Sprites._charHeightBolt;
                    break;
                case "twin":
                    charArray[0] = Sprites._charWidthTwin;
                    charArray[1] = Sprites._charHeightTwin;
                    charArray[2] = Sprites._cornerTopRightTwin;
                    charArray[3] = Sprites._cornerTopLeftTwin;
                    charArray[4] = Sprites._cornerBottomLeftTwin;
                    charArray[5] = Sprites._cornerBottomRightTwin;
                    break;
                case "shadowLow":
                    charArray[0] = Sprites._charShadowLow;
                    charArray[1] = Sprites._charShadowLow;
                    charArray[2] = Sprites._charShadowLow;
                    charArray[3] = Sprites._charShadowLow;
                    charArray[4] = Sprites._charShadowLow;
                    charArray[5] = Sprites._charShadowLow;
                    break;
                case "shadowMiddle":
                    charArray[0] = Sprites._charShadowMiddle;
                    charArray[1] = Sprites._charShadowMiddle;
                    charArray[2] = Sprites._charShadowMiddle;
                    charArray[3] = Sprites._charShadowMiddle;
                    charArray[4] = Sprites._charShadowMiddle;
                    charArray[5] = Sprites._charShadowMiddle;
                    break;
                case "shadowHigh":
                    charArray[0] = Sprites._charShadowHigh;
                    charArray[1] = Sprites._charShadowHigh;
                    charArray[2] = Sprites._charShadowHigh;
                    charArray[3] = Sprites._charShadowHigh;
                    charArray[4] = Sprites._charShadowHigh;
                    charArray[5] = Sprites._charShadowHigh;
                    break;
                case "half":
                    charArray[0] = Sprites._blockUp;
                    charArray[1] = Sprites._blockDown;
                    charArray[2] = Sprites._cornerTopRightBolt;
                    charArray[3] = Sprites._cornerTopLeftBolt;
                    charArray[4] = Sprites._cornerBottomLeftBolt;
                    charArray[5] = Sprites._cornerBottomRightBolt;
                    break;
                case "halfUp":
                    charArray[0] = Sprites._blockUp;
                    charArray[1] = Sprites._blockUp;
                    charArray[2] = Sprites._blockUp;
                    charArray[3] = Sprites._blockUp;
                    charArray[4] = Sprites._blockUp;
                    charArray[5] = Sprites._blockUp;
                    break;
                case "halfDown":
                    charArray[0] = Sprites._blockDown;
                    charArray[1] = Sprites._blockDown;
                    charArray[2] = Sprites._blockDown;
                    charArray[3] = Sprites._blockDown;
                    charArray[4] = Sprites._blockDown;
                    charArray[5] = Sprites._blockDown;
                    break;
                case "black&white":
                    charArray[0] = Sprites._Block;
                    charArray[1] = Sprites._Block;
                    charArray[2] = Sprites._Block;
                    charArray[3] = Sprites._Block;
                    charArray[4] = Sprites._Block;
                    charArray[5] = Sprites._Block;
                    break;
                case "thin":
                    charArray[0] = Sprites._cornerTopRight_Thin;
                    charArray[1] = Sprites._cornerTopLeft_Thin;
                    charArray[2] = Sprites._cornerBottomLeft_Thin;
                    charArray[3] = Sprites._cornerBottomRight_Thin;
                    charArray[4] = Sprites._charWidth_Thin;
                    charArray[5] = Sprites._charHeight_Thin;
                    break;
                case "arrow":
                    charArray[0] = Sprites._cornerTopRightArrow;
                    charArray[1] = Sprites._cornerTopLeftArrow;
                    charArray[2] = Sprites._cornerBottomLeftArrow;
                    charArray[3] = Sprites._cornerBottomRightArrow;
                    charArray[4] = Sprites._charWidthArrow;
                    charArray[5] = Sprites._charHeightArrow;
                    break;
                default:
                    charArray[0] = Sprites._charHeightBolt;
                    charArray[1] = Sprites._charHeightBolt;
                    charArray[2] = Sprites._charHeightBolt;
                    charArray[3] = Sprites._charHeightBolt;
                    charArray[4] = Sprites._charHeightBolt;
                    charArray[5] = Sprites._charHeightBolt;
                    break;
            }
            return charArray;
        }
        static void CharToPosition(int posY, int posX, char Char)
        {
            if (posX <= 0 || posY <= 0) { return; }
            if (posY >= Console.WindowWidth || posX >= Console.WindowHeight) { return; }

            Console.SetCursorPosition(posY, posX);
            Console.Write(Char);
            Console.CursorVisible = false;
        }
    }
}
