using Maya.Drawing;
using System;

namespace Maya.Engine
{
    public class MainWindow : MayaEngine, IMayaEngine
    {
        public static string WindowStyle { get; set; } = "bolt";

        public static ConsoleColor BackGroundColor { get; set; } = ConsoleColor.Black;

        public MainWindow(int widthX, int heightY, ConsoleColor color) 
        {
            DrawWindow(widthX, heightY, color, WindowStyle);
            InitWindow(widthX, heightY);
        }
        static void DrawWindow(int widthX, int heightY, ConsoleColor color, string style)
        { 
            Console.WindowWidth = widthX;
            Console.WindowHeight = heightY;
            Console.BufferWidth = widthX;
            Console.BufferHeight = heightY; 
            IFrame frame = new FrameStyle(widthX, heightY, color, style);
            Console.BackgroundColor = BackGroundColor;
            frame.Draw();
        }
        static void InitWindow(int widthX, int heightY)
        {
            Console.SetWindowSize(widthX + 1, heightY + 1);
            Console.SetBufferSize(widthX + 1, heightY + 1);
            Entity._widthX = widthX + 1;
            Entity._heightY = heightY + 1;
            Entity._isDrawed = true;
            Entity._style = WindowStyle;            
        }
    }
}