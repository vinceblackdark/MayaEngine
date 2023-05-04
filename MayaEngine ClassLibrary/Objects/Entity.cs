using System;
namespace Maya.Engine
{
    public class Entity : MayaEngine, IMayaEngine
    {
        public string _name;
        public static string _style;

        public int dx;
        public int dy;
        public int posX;
        public int posY;

        public static int _widthX { get; set; }
        public static int _heightY { get; set; }

        public static double _timeSpan { get; set; } = 1000.0;

        public static bool _isDrawed;
        public static bool _isChanged;

        // public MainWindow MainWindow { get; set; }  

        // public MayaTimer MayaTimer { get; set; }

        // public Player Player { get; set; }

        // public Vehicle Vehicle { get; set; }

        // public MayaObjects MayaObjects { get; set; }

        // public MayaAnimation MayaAnimation { get; set; }

        public Entity(string name) 
        {
            _name = name;
            Console.Title = _name;
        }

        public static bool CheckChanges()
        {
            if(_widthX != Console.WindowWidth || _heightY != Console.WindowHeight) { return true; }
            if (_isChanged == true) { return _isChanged; }
            return false;
        }

        public static void InitTimeSpan()
        {
            MayaTimer._timespan = _timeSpan;
        }
    }
}
