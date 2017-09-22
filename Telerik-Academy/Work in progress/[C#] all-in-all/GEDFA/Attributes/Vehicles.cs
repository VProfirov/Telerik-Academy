using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCore
{
    class Vehicle
    {
        private readonly bool _canMove;

        public Vehicle()
        {

        }
        public Vehicle(bool isMoveable)
        {
            this._canMove = isMoveable;
        }

        public bool Move
        {
            get { return this._canMove; }
        }

    }
}
