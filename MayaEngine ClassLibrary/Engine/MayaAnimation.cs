using Maya.Drawing;
using System.Threading;
using System;
using System.Collections.Generic;

namespace Maya.Engine
{
    public sealed class MayaAnimation : MayaEngine, IAnimation, IRender, ISprites
    {
        public static void SpriteGirl()
        {
            const string Girl1 =
            @"    	(()))())()).       " + "\n" +
            @"     (()""````""::= )    " + "\n" +
            @"     )| _    _ ::= )     " + "\n" +
            @"    (()(o)/ (o) ?(/)     " + "\n" +
            @"     )(::c ::.( :(/)     " + "\n" +
            @"    (( \ .__. ;,/(/)     " + "\n" +
            @"       ) `.___,'/ (/)    " + "\n" +
            @"         |    | (/)      " + "\n" +
            @"       _.'    ,\(/)__    " + "\n" +
            @"   _.-""   ` u    (/) ""." + "\n" +
            @" ,""               ^    \" + "\n" +
            @"/                      | " + "\n" +
            @"|           .      `.  | " + "\n" +
            @"|   /,'   _  `.'   _ `.| " + "\n" +
            @"|   ||   (.)  |   (.) || " + "\n" +
            @"|   |\       ;        /) " + "\n" +
            @"(   \ `.,___,' `.,__,'/  " + "\n" +
            @" \   \ |           | /   " + "\n" +
            @"  \   `;           |/    " + "\n" +
            @"   `. /            |     " + "\n" +
            @"     Y             |     " + "\n" +
            @"    /          (   |     " + "\n" +
            @"   /               ;     ";

            const string Girl2 =
            @"    	(()))())()).       " + "\n" +
            @"     (()""````""::= )    " + "\n" +
            @"     )| _    _ ::= )     " + "\n" +
            @"    (()(o)/ (o) ?(/)     " + "\n" +
            @"     )(::c ::.( :(/)     " + "\n" +
            @"    (( \ .__. ;,/(/)     " + "\n" +
            @"       ) `.___,'/ (/)    " + "\n" +
            @"         |    | (/)      " + "\n" +
            @"       _.'    ,\(/)__    " + "\n" +
            @"   _.-""   ` u    (/) ""." + "\n" +
            @" ,""               ^    \" + "\n" +
            @"/                      | " + "\n" +
            @"|           .      `.  | " + "\n" +
            @"|   /,'   _  `.'   _ `.| " + "\n" +
            @"|   ||        |       || " + "\n" +
            @"|   |\   (.) ;   (.)  /) " + "\n" +
            @"(   \ `.,___,' `.,__,'/  " + "\n" +
            @" \   \ |           | /   " + "\n" +
            @"  \   `;           |/    " + "\n" +
            @"   `. /            |     " + "\n" +
            @"     Y             |     " + "\n" +
            @"    /          (   |     " + "\n" +
            @"   /               ;     ";

            while (true)
            {
                Console.Write(Girl1);
                Thread.Sleep(500);
                Console.Clear();
                Console.Write(Girl2);
                Thread.Sleep(500);
                Console.Clear();
            }
        }


        public void Animate()
        {

        } //empty
        public void DrawSprite()
        { } //empty
        public void GetSprite()
        { } //empty
        public void Render(char[][] map, Dictionary<char, string> textures)
        { } //empty
    }
}