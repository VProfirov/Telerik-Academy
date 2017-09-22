using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Shelter<T>
    {
        public const int DefaultPlacesCount = 20;

        private T[] animalList;

        private int usedPlaces;

        public Shelter():this(DefaultPlacesCount)
        {
            
        }

        public Shelter(int placesCount)
        {
            this.animalList = new T[placesCount];
            this.usedPlaces = 0;
        }

        public void ShelterAnimal(T newAnimal)
        {
            if (this.usedPlaces > this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public T Release(int index)
        {
            if (index<0 || index>this.animalList.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid cell index: " + index);
            }
            T releasedAnimal = this.animalList[index];
            for (int i = index; i < this.animalList.Length-1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = default(T);
            this.usedPlaces--;

            return releasedAnimal;
        }

        public int Length()
        {
            return this.usedPlaces;
        }
    }
}
