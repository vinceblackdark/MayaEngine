using Maya.Engine;

namespace Maya.Drawing
{
    public sealed class Sprites : MayaEngine, ISprites
    {
        // empty
        public void DrawSprite()
        {

        }
        public void GetSprite()
        { }

        // Chars
        #region Chars 
        public const char _cornerTopRightTwin = '╔';
        public const char _cornerTopLeftTwin = '╗';
        public const char _cornerBottomLeftTwin = '╚';
        public const char _cornerBottomRightTwin = '╝';
        public const char _charWidthTwin = '═';
        public const char _charWidthUpTwin = '╩';
        public const char _charWidthDownTwin = '╦';
        public const char _charHeightTwin = '║';
        public const char _charHeightLeftTwin = '╣';
        public const char _charHeightRightTwin = '╠';
        public const char _charCrossTwin = '╬';

        public const char _charShadowLow = '░';
        public const char _charShadowMiddle = '▒';
        public const char _charShadowHigh = '▓';

        public const char _charWidthBolt = '■';
        public const char _charHeightBolt = '█';
        public const char _cornerTopRightBolt = '▄';
        public const char _cornerTopLeftBolt = '▄';
        public const char _cornerBottomLeftBolt = '▀';
        public const char _cornerBottomRightBolt = '▀';

        public const char _Block = '■';
        public const char _blockUp = '▀';
        public const char _blockDown = '▄';
        public const char _BlockFull = '█';
        public const char _BlockFullLeft = '▌';
        public const char _BlockFullRight = '▐';

        public const char _charWidth_Thin = '_';
        public const char _charHeight_Thin = '|';
        public const char _cornerTopRight_Thin = '/';
        public const char _cornerTopLeft_Thin = '\\';
        public const char _cornerBottomRight_Thin = '/';
        public const char _cornerBottomLeft_Thin = '\\';

        public const char _charWidthArrow = '^';
        public const char _charHeightArrow = '^';
        public const char _cornerTopRightArrow = '>';
        public const char _cornerTopLeftArrow = '<';
        public const char _cornerBottomLeftArrow = '<';
        public const char _cornerBottomRightArrow = '>';
        public const char _heart = '♥';
        public const char _kreutz = '♣';
        public const char _caro = '♦';
        public const char _pik = '♠';
        public const char _charEmpty = ' ';
        #endregion Chars

        // Strings and Arrays
        #region Strings and Arrays
        public const string p0 = ":♥>";
        public const string p1 = ":¶>";
        public const string p2 = ":~↑";
        public const string p3 = "┤░>";
        public const string p4 = "§:&>";
        public const string p5 = "~$";
        public const string p6 = "§:>";
        public const string p7 = "~>";

        public static string[] MoveDirections = { "left", "right", "up", "down" };

        public static string[] _colorArrayFG0 = { "greenfg", "bluefg", "redfg", "yellowfg", "magentafg", "cyanfg", };

        public static string[] _colorArrayBG0 = { "greenbg", "bluebg", "redbg", "yellowbg", "magentabg", "cyanbg", };

        public static string[] _colorArrayFG1 = { "darkgreenfg", "darkbluefg", "darkredfg", "darkyellowfg", "darkmagentafg", "darkcyanfg", };

        public static string[] _colorArrayBG1 = { "darkgreenbg", "darkbluebg", "darkredbg", "darkyellowbg", "darkmagentabg", "darkcyanbg", };

        public static char[] charArrayDots = { '.', ',', '.', ',', ',' };

        public static char[] charArrayDotsUp = { '´', '"', '\'', };

        public static char[] charArrayDotsDowm = { ';', ':' };

        public static char[] waterFrame = { '~', '^', '~', ',', '´', '~', '-', '/', '~', ' ' };

        public static char[] charArrayBlock = { '■', '■', '■', '■', '■', '■', '■', '■', };

        public static char[] charArrayShadowLow = { '░', '░', '░', '░', '░', '░', '░', '░', };

        public static char[] charArrayShadowMiddle = { '▒', '▒', '▒', '▒', '▒', '▒', '▒', '▒', };

        public static char[] charArrayShadowHigh = { '▒', '▒', '▓', '▓', '▓', '▓', '▓', '▓' };

        public static char[] _charsx2 = new char[2];
        public static char[] _charsx4 = new char[4];
        public static char[] _charsx8 = new char[8];
        public static char[] _charsx16 = new char[16];
        public static char[] _charsx32 = new char[32];
        #endregion Strings and Arrays

        // Texture Sprites
        #region Texture Sprites

        public const string Ground =
        @"██████" + "\n" +
        @"██████" + "\n" +
        @"██████";
        public const string MapEnd =
        @"XXXXXX" + "\n" +
        @"XXXXXX" + "\n" +
        @"XXXXXX";
        public const string Chess =
        @"▀▄▀▄▀▄▀" + "\n" +
        @"▀▄▀▄▀▄▀" + "\n" +
        @"▀▄▀▄▀▄▀" + "\n" +
        @"▀▄▀▄▀▄▀";
        public const string Water =
        @"~~~~~~~" + "\n" +
        @"~~~~~~~" + "\n" +
        @"~~~~~~~" + "\n" +
        @"~~~~~~~";
        public const string Barrels1 =
        @"       " + "\n" +
        @"  /---\ " + "\n" +
        @"/-\/-\|" + "\n" +
        @"\ /\ //";
        public const string Barrels2 =
        @"       " + "\n" +
        @"/---\  " + "\n" +
        @"|/-\/-\" + "\n" +
        @"\\ /\ /";
        public const string Barrels3 =
        @"       " + "\n" +
        @" /---\ " + "\n" +
        @"/--\/-\" + "\n" +
        @"\  /\ /";
        public const string Tree =
        @" /---\ " + "\n" +
        @" \___/ " + "\n" +
        @"  | |  " + "\n" +
        @"  / \  ";
        public const string Tree2 =
        @"  (@@) " + "\n" +
        @" (@@@@)" + "\n" +
        @"   ||  " + "\n" +
        @"   ||  ";
        public const string Wall_0000 =
        @"╔═════╗" + "\n" +
        @"║█████║" + "\n" +
        @"║█████║" + "\n" +
        @"╚═════╝";
        public const string Wall_0001 =
        @"══════╗" + "\n" +
        @"██████║" + "\n" +
        @"██████║" + "\n" +
        @"══════╝";
        public const string Wall_0010 =
        @"╔═════╗" + "\n" +
        @"║█████║" + "\n" +
        @"║█████║" + "\n" +
        @"║█████║";
        public const string Wall_0011 =
        @"══════╗" + "\n" +
        @"██████║" + "\n" +
        @"██████║" + "\n" +
        @"╗█████║";
        public const string Wall_0100 =
        @"╔══════" + "\n" +
        @"║██████" + "\n" +
        @"║██████" + "\n" +
        @"╚══════";
        public const string Wall_0101 =
        @"═══════" + "\n" +
        @"███████" + "\n" +
        @"███████" + "\n" +
        @"═══════";
        public const string Wall_0110 =
        @"╔══════" + "\n" +
        @"║██████" + "\n" +
        @"║██████" + "\n" +
        @"║█████╔";
        public const string Wall_0111 =
        @"═══════" + "\n" +
        @"███████" + "\n" +
        @"███████" + "\n" +
        @"╗█████╔";
        public const string Wall_1000 =
        @"║█████║" + "\n" +
        @"║█████║" + "\n" +
        @"║█████║" + "\n" +
        @"╚═════╝";
        public const string Wall_1001 =
        @"╝█████║" + "\n" +
        @"██████║" + "\n" +
        @"██████║" + "\n" +
        @"══════╝";
        public const string Wall_1010 =
        @"║█████║" + "\n" +
        @"║█████║" + "\n" +
        @"║█████║" + "\n" +
        @"║█████║";
        public const string Wall_1011 =
        @"╝█████║" + "\n" +
        @"██████║" + "\n" +
        @"██████║" + "\n" +
        @"╗█████║";
        public const string Wall_1100 =
        @"║█████╚" + "\n" +
        @"║██████" + "\n" +
        @"║██████" + "\n" +
        @"╚══════";
        public const string Wall_1101 =
        @"╝█████╚" + "\n" +
        @"███████" + "\n" +
        @"███████" + "\n" +
        @"═══════";
        public const string Wall_1110 =
        @"║█████╚" + "\n" +
        @"║██████" + "\n" +
        @"║██████" + "\n" +
        @"║█████╔";
        public const string Wall_1111 =
        @"╝█████╚" + "\n" +
        @"███████" + "\n" +
        @"███████" + "\n" +
        @"╗█████╔";
        public const string Mountain =
        @"   /\  " + "\n" +
        @"  /--\ " + "\n" +
        @" /    \" + "\n" +
        @"/      ";
        public const string Mountain2 =
        @"   /\  " + "\n" +
        @"  /\/\ " + "\n" +
        @" /    \" + "\n" +
        @"/      ";
        public const string Mountain3 =
        @"   /\  " + "\n" +
        @"  /**\ " + "\n" +
        @" /    \" + "\n" +
        @"/      ";
        public const string Texture0 =
        @"╔══ ══╗" + "\n" +
        @"║▀▀ ▀▀║" + "\n" +
        @"║▄▄ ▄▄║" + "\n" +
        @"╚══ ══╝";
        public const string Texture1 =
        @"╔══ ══╗" + "\n" +
        @"║╔═══╗║" + "\n" +
        @"║╚═══╝║" + "\n" +
        @"╚══ ══╝";
        public const string Building =
        @" /---\ " + "\n" +
        @"/-----\" + "\n" +
        @"|     |" + "\n" +
        @"|  █  |";
        public const string Inn =
        @" /---\ " + "\n" +
        @"/-Inn-\" + "\n" +
        @"|     |" + "\n" +
        @"|  █  |";
        public const string Store =
        @" /---\ " + "\n" +
        @"/Store\" + "\n" +
        @"|     |" + "\n" +
        @"|  █  |";
        #endregion Texture Sprites

        // Sprite Array
        #region Sprite Arrays
        public static readonly string[] MayaAscii = new[]
   {@"                                                                    " + '\n' +
            @" __       __                                       ______   ______  " + '\n' +
            @"|  \     /  \                                     /      \ |      \ " + '\n' +
            @"| $$\   /  $$  ______   __    __   ______        |  $$$$$$\ \$$$$$$ " + '\n' +
            @"| $$$\ /  $$$ |      \ |  \  |  \ |      \       | $$__| $$  | $$   " + '\n' +
            @"| $$$$\  $$$$  \$$$$$$\| $$  | $$  \$$$$$$\      | $$    $$  | $$   " + '\n' +
            @"| $$\$$ $$ $$ /      $$| $$  | $$ /      $$      | $$$$$$$$  | $$   " + '\n' +
            @"| $$ \$$$| $$|  $$$$$$$| $$__/ $$|  $$$$$$$      | $$  | $$ _| $$_  " + '\n' +
            @"| $$  \$ | $$ \$$    $$ \$$    $$ \$$    $$      | $$  | $$|   $$ \ " + '\n' +
            @" \$$      \$$  \$$$$$$$ _\$$$$$$$  \$$$$$$$       \$$   \$$ \$$$$$$ " + '\n' +
            @"                       |  \__| $$                                   " + '\n' +
            @"                        \$$    $$                                   " + '\n' +
            @"                         \$$$$$$                                    "};


        public static readonly string[] Colt = new[]
            {@" ,-.______________,=========,       " + '\n' +
             @"[|  )_____________)#######((_       " + '\n' +
             @" /===============.-.___,--  _ \     " + '\n' +
             @"  -._,__,__[JW] ____\######""//     " + '\n' +
             @"          \ (  )) )####O##(         " + '\n' +
             @"           \ \___/,.#######\        " + '\n' +
             @"             `====   \#######\      " + '\n' +
             @"                      \#######\     " + '\n' +
             @"                       \##O####|    " + '\n' +
             @"                         \####/     " + '\n' +
             @"                          `--       "};



        public static readonly string[] Stones = new[]
        {@"           __            " + '\n' +
            @"          |  |           " + '\n' +
            @"     /|   |  |   |\      " + '\n' +
            @"    | |   |  |   | |     " + '\n' +
            @"    | |          | |     " + '\n' +
            @"    |              |     " + '\n' +
            @" |                   |   " + '\n' +
            @" |                   |   " + '\n' +
            @" |                   |   " + '\n' +
            @"  |\               /|    " + '\n' +
            @"  | |      __     | |    " + '\n' +
            @"  | |     |  |    | |    " + '\n' +
            @"    |     |  |    |      " + '\n' +
            @"          |  |           "};

        public static readonly string[] Flower0 = new[]
           {@"    _,-._   " + '\n' +
            @"   / \_/ \  " + '\n' +
            @"   >-(_)-<  " + '\n' +
            @"   \_/ \_/  " + '\n' +
            @"     `-'    "};
        #endregion Sprite Arrays

        // Sprite Animation Arrays
        #region Sprite Animation

        public readonly string[] IdleBoar = new[]
        {
		    // 0
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 1
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 2
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ', ,' ",
		    // 3
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ', ,' ",
		    // 4
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ', ,' ",
		    // 5
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ', ,' ",
		    // 6
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ', ,' ",
		    // 7
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,' ', ",
		    // 8
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,' ', ",
		    // 9
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,' ', ",
		    // 10
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,' ', ",
		    // 11
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,' ', ",
		    // 12
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 13
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 14
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 15
		    @" ^..^  " + '\n' +
            @"(oo)\  " + '\n' +
            @"  O  )~" + '\n' +
            @" '' ,, ",
		    // 16
		    @" ^..^  " + '\n' +
            @"(oo)\  " + '\n' +
            @"  O  )~" + '\n' +
            @" '' ,, ",
		    // 17
		    @" ^..^  " + '\n' +
            @"(oo)\  " + '\n' +
            @"  O  )~" + '\n' +
            @" '' ,, ",
		    // 18
		    @" ^..^  " + '\n' +
            @"(oo)\  " + '\n' +
            @"  O  )~" + '\n' +
            @" '' ,, ",
		    // 19
		    @" ^..^  " + '\n' +
            @"(oo)\  " + '\n' +
            @"  O  )~" + '\n' +
            @" '' ,, ",
		    // 20
		    @"       " + '\n' +
            @"^--^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 21
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 22
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 23
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 24
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 25
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 26
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
		    // 27
		    @"       " + '\n' +
            @"^..^   " + '\n' +
            @"(oo) )~" + '\n' +
            @" ,, ,, ",
            };

        public readonly string[] Sekt = new[]
        {
            @" * " + '\n' +
            @"*_ " + '\n' +
            @"|*|" + '\n' +
            @"|_|" + '\n' +
            @"\*/" + '\n' +
            @"_|_",
            // 1
            @"*  " + '\n' +
            @" _*" + '\n' +
            @"|*|" + '\n' +
            @"|_|" + '\n' +
            @"\*/" + '\n' +
            @"_|_"
            // 2
            };

        #endregion Sprite Animation
    }
}
