﻿using System;
using System.Windows.Forms;

namespace PoliticianCrusade
{
    [Version ("000.830")]
    public class Game
    {
        static string pathIntro = @"..\..\intro_screen.txt";
        public const int MaxHeight = 40;
        public const int MaxWidth = 100;
        
        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = MaxHeight;
            Console.BufferWidth = Console.WindowWidth = 70;

            DrawScreen.IntroPlayer(pathIntro);

            Console.ReadKey();
            Console.Clear();

            Console.BufferWidth = Console.WindowWidth = MaxWidth;

            Engine.Action();
        }
    }
}
