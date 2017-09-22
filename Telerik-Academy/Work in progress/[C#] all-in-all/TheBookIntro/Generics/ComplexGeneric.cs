using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ComplexGeneric<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

        //the method T hides(!=) the class T
        public void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
    }

    class GenericList<T>
    {
        // CS0693
        void SampleMethod<T>() { }
    }

    class GenericList2<T>
    {
        //No warning
        void SampleMethod<U>() { }
    }
}
