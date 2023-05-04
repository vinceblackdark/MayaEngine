using System.IO;
using System;
using System.Collections.Generic;

namespace Maya.Drawing
{
    public sealed class MayaDrawing
    {
        public static void WriteString(int posX, int posY, string value)
        {
            if (posX > 0 && posX < Console.WindowWidth &&
                posY > 0 && posY < Console.WindowHeight)
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write(value);
                Console.CursorVisible = false;
            }
        }
        public static void WriteChar(int posX, int posY, char value)
        {
            WriteString(posX, posY, value.ToString());
        }
        public static bool CompareAToB(char chA, char chB)
        {
            return chA.Equals(chB);
        }
        public static bool CompareBToA(char chA, char chB)
        {
            return chB.Equals(chA);
        }
        public static void WriteFile(int posX, int posY, ConsoleColor color, string file)
        {
            if (File.Exists(file))
            {
                string text = File.ReadAllText(file);
                Console.CursorVisible = false;
                Console.ForegroundColor = color;
                WriteString(posX, posY, text);
            }
        }
        public static List<int> FindStrings(string[] search, string searchIn)
        {
            List<int> indices = new List<int>();
            foreach (string searchString in search)
            {
                int index = searchIn.IndexOf(searchString);
                if (index != -1)
                {
                    indices.Add(index);
                }
            }
            return indices;
        }
        public static string ReplaceChar(string file, char a, char b)
        {
            string content = File.ReadAllText(file);
            content = content.Replace(a, b);
            File.WriteAllText(file, content);
            return content;
        }
    }
    public interface IRectangle
    {
        void Draw();
    }
    public interface ITriangle
    {
        void Draw();
    }
    public interface ICircle
    {
        void Draw();
    }
    public interface IFrame
    {
        void Draw();
    }
    public interface ILine
    {
        void Draw();
    }
    public interface IPoint
    {
        void Draw();
    }
    public interface ISprites
    {
        void DrawSprite();
        void GetSprite();
    }
    public interface IAnimation
    {
        void Animate();
    }
}

// Core, all other drawing classes will need Methods provided by this class