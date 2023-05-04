using Maya.Drawing;
using System;
using System.Timers;
namespace Maya.Engine
{
    public class MayaTimer : ITimer
    {
        private Timer _timer;
        private static long _tickPerSec = TimeSpan.TicksPerSecond;
        private int _frameCount = 0;
        private double _elapsedTime = 0.0;
        private double _fps = 0.0;

        public static double _timespan = 1000.0;

        public void InitTimer()
        {
            _timer = new Timer(TimeSpan.FromMilliseconds(_timespan).TotalMilliseconds); // Erstellt einen Timer, der alle 1000 Millisekunden ausgelöst wird
            _timer.Elapsed += OnTimedEvent; // Fügt eine Methode hinzu, die bei jedem Auslösen des Timers aufgerufen wird
            _timer.AutoReset = true; // Stellt sicher, dass der Timer immer wieder ausgelöst wird
            _timer.Enabled = true; // Aktiviert den Timer
            string output = Console.ReadLine(); // Hält die Anwendung offen, um den Timer weiterlaufen zu lassen
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            double deltaTime = e.SignalTime.Ticks;

            _elapsedTime += deltaTime;
            _frameCount++;

            if (_elapsedTime >= 1.0)
            {
                _fps = _frameCount / _elapsedTime;
                _frameCount = 0;
                _elapsedTime = 0.0;
            }

            MayaEngine.OnTimedEvent(source, e, _fps);
        }
    }
}
