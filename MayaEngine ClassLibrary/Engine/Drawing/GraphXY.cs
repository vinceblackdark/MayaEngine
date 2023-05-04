using System;

namespace Maya.Drawing
{
    public class GraphXY : ILine
    {
        private int _WidthX { get; set; }
        private int _HeightY { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public int _Size { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }
        public GraphXY(int posX,int posY, int size, string color, char style)
        {
            _Size = size;
            _WidthX = size;
            _HeightY = size;
            _posY = posY;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            for (int x = 1; x < _WidthX; x++) { MayaDrawing.WriteChar(_posX + x, _posY + 1,  _Style); }
            for (int y = 1; y <= _HeightY; y++) { MayaDrawing.WriteChar(_posX + 1, _posY + y + 1, _Style); }
        }
    }
}
