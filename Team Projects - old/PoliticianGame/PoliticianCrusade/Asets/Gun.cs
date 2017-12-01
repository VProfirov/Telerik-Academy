﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PoliticianCrusade
{
    public class Gun : StaticObject, IResource, IWeapon
    {
        public readonly int Price = 50;
        private static int xCoord = 92;
        private static int yCoord = 35;

        public Gun() 
                : base(xCoord, yCoord)
        {
            this.RemainingPower = 100;
        }

        #region Properties
        public ResourceType Type
        {
            get { return ResourceType.Weapon; }
        }

        public int WearPerUse
        {
            get { return 100; }
        }

        public int Damage
        {
            get { return 150; }
        }

        public int RemainingPower
        {
            get;
            set;
        } 
        #endregion

        #region DrawImage
        public override char[,] GetImage()
        {
            return new char[,] { 
                                 { '=', '=', '=' , '='} ,
                                 { '=', '=' ,'=', '|'} ,
                                 { ' ', ' ', '|', '|'} ,
                                 
            };
        }

        public override void RenderImg()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            base.RenderImg();
        }   
        #endregion
    }
}
