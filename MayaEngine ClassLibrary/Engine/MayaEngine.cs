using System;
using System.Collections.Generic;
using System.Timers;
using Maya.Drawing;
namespace Maya.Engine
{
    public abstract class MayaEngine : IMayaEngine, ITimer, IMove, IRectangle, IPoint, IFrame, ILine, ICircle
    { 
        private int widthX;
        private int heightY;

        private static int dx;
        private static int dy;
        private static int posX;
        private static int posY;
        private static int width;
        private static int height;
        private static int radius;
        private static int volume;

        private static bool _Animate;
        private static bool _Moving;

        private static bool _isDrawed;
        private static bool _isAnimated;
        private static bool _isMoved;
        private static bool _isChanged;

        public void DrawMainWindow(string dimension, ConsoleColor color)
        {
            MainWindow mainWindow;
            switch (dimension)
            {
                case "full":
                    widthX = Console.LargestWindowWidth - 2;
                    heightY = Console.LargestWindowHeight - 2;
                    mainWindow = new MainWindow(widthX, heightY,color);
                   break;
                case "middle":
                    widthX = (Console.LargestWindowWidth / 2) + 20;
                    heightY = (Console.LargestWindowHeight / 2) + 10;
                    mainWindow = new MainWindow(widthX, heightY, color);
                   break;
                case "small":
                    widthX = (Console.LargestWindowWidth / 4) + 30;
                    heightY = (Console.LargestWindowHeight / 4) + 15;
                    mainWindow = new MainWindow(widthX, heightY, color);
                    break;
                default:
                    widthX = (Console.LargestWindowWidth / 2) + 20;
                    heightY = (Console.LargestWindowHeight / 2) + 10;
                    mainWindow = new MainWindow(widthX, heightY, color);
                    break;         
            }
        }
        public void InitTimer()
        {
            if (Entity._isDrawed == false) { return; }
            MayaTimer mayaTimer = new MayaTimer();
            Entity.InitTimeSpan();
            mayaTimer.InitTimer();
        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e, double _fps)
        { 
            MayaDrawing.WriteString(2, Console.WindowHeight - 2, $"{0}{e.SignalTime} - {Entity.CheckChanges()} - FPS: {_fps}");
        }
        public void Move(Object source)
        {
            
        }
        public void Draw()
        {
        } // empty Method
    }
   
    public abstract class MayaErrorHandler : MayaEngine, IMayaEngine
    {
        public static void CheckBounds(int posX, int posY, int width, int height, ref int dx, ref int dy, BoundsAction action)
        {

            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int x = posX;
            int y = posY;

            if (posX >= 0 && posY <= consoleWidth && height >= 0 && width <= consoleHeight)
            {
                return;
            }

            switch (action)
            {
                case BoundsAction.Cancel:
                    throw new InvalidOperationException("Animation cancelled due to rectangle exceeding console bounds.");
                case BoundsAction.Reverse:
                    dx = -dx;
                    dy = -dy;
                    break;
                case BoundsAction.Wrap:

                    if (posX < 1)
                    {
                        posX += consoleWidth + width;
                    }
                    else if (width > consoleWidth)
                    {
                        posX -= consoleWidth + width;
                    }
                    if (posX < 1)
                    {
                        posY += consoleHeight + height;
                    }
                    else if (height > consoleHeight)
                    {
                        posY -= consoleHeight + height;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, "Invalid bounds action.");
            }
            CheckBoundsAndHandle(() => Console.SetCursorPosition(x, y));
        }
        public static void CheckBoundsAndHandle(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException || ex is IndexOutOfRangeException)
            {
                // Char went out of bounds
                // Do nothing and let it disappear
                //GetError(001);
            }
        }
        public enum BoundsAction
        {
            Cancel, // Animation abbrechen
            Reverse, // Richtung umkehren
            Wrap // Zum gegenüberliegenden Rand verschieben
        }

        private static Dictionary<int, string> errorcode = new Dictionary<int, string>
            {
                { 001, "error [Index Error]" },
                { 002, "error [args]" },
                { 003, "error [file not found]" },
                { 004, "error [directoy not found]" },
                { 005, "error [source not found]" },
                { 006, "error [destination not found]" },
                { 007, "error [file exists]" },
                { 008, "error [directory exists]" },
                { 009, "error [no integer]" },
                { 010, "error [negative value]" },
                { 011, "error [no value]" },
                { 012, "error [value too long]" },
                { 013, "error [value too short]" },
                { 014, "error [color not found]" },
                { 015, "error [tone not found]" },
                { 016, "error [missing args]" },
                { 017, "error [exception]" }
            };
        public static string GetError(int error)
        {
            if (errorcode.ContainsKey(error))
            {
                return errorcode[error];
            }
            else
            {
                return "error";
            }
        }
    }

    public interface IMayaEngine
    {
        void DrawMainWindow(string dimension, ConsoleColor color);
    }
    public interface IMove
    {
        void Move(Object source);
    }
    public interface ITimer
    {
        void InitTimer();
    }
    public interface IRender
    {
        void Render(char[][] map, Dictionary<char, string> textures);
    }
    public interface IPlayer
    {
        void CheckBounds();
        void Move();
        void Animate();
        void Action();
    }
} // core class for all other Engine classes
