using Maya.Engine;
using System;
using System.Collections.Generic;

namespace Maya.Drawing
{
    public class MayaRender : MayaEngine, IMayaEngine, ITimer, IRender
    {
        public char[][] map = new char[][]
             {
            "##################################".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "#                                #".ToCharArray(),
            "##################################".ToCharArray(),
             };
        public Dictionary<char, string> textures = new Dictionary<char, string>()
            {
            { '#', Sprites.MapEnd },
            { 'w', Sprites.MapEnd },
            { ' ', Sprites.Ground }};

        public void Render(char[][] map, Dictionary<char, string> textures)
        {
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int tileWidth = consoleWidth / map[0].Length;
            int tileHeight = consoleHeight / map.Length;
            if (tileWidth > 6)
            {
                tileWidth = 6;
            }
            if (tileHeight > 3)
            {
                tileHeight = 3;
            }
            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    string texture = textures.ContainsKey(map[i][j]) ? textures[map[i][j]] : " ";
                    Console.SetCursorPosition(j * tileWidth, i * tileHeight);
                    Console.Write(texture.PadRight(tileWidth * tileHeight));
                }
            }
        }

    }
}
