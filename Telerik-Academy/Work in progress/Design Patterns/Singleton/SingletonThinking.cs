using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonThinking
    {
        private static SingletonThinking _instance;
        private SingletonThinking()
        {
            
        }

        public static SingletonThinking GetNewInstance
        {
            get
            {
                if (_instance == null)
                {
                    return _instance = new SingletonThinking();
                }
                return _instance;
            }
        }

        public int SomeNumericData { get; set; } = 0;


        public static SingletonThinking GetNewInstanceQuickProp => _instance ?? (_instance = new SingletonThinking()); // not readonly =>  multiple instance when called
    }
}
