﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticianCrusade
{
    public class Cane : StaticObject, IResource, IWeapon
    {
        public readonly int Price = 100;
        protected static int xCoord = 57;
        private static int yCoord = 34;
       
        public Cane() 
            : base(xCoord, yCoord)
        {
            this.RemainingPower = 100;
        }

        #region Properties
        public int RemainingPower
        {
            get;
            set;
        }

        public int WearPerUse
        {
            get { return 20; }
        }

        public int Damage
        {
            get { return 50; }
        }

        public ResourceType Type
        {
            get { return ResourceType.Weapon; }
        }

        #endregion

        #region DrawImageMethods
        public override char[,] GetImage()
        {
            return new char[,] { 
                                 { '_', '_' } ,
                                 { '|', '|' } ,
                                 { ' ', '|',} ,
                                 { ' ', '|',} ,
                                 
            };
        }

        public override void RenderImg()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            base.RenderImg();
        } 
        #endregion
    }
}
