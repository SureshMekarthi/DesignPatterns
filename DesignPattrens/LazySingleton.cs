using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class LazySingleton
    {
        private static LazySingleton _instance;

        private LazySingleton()
        {
        }

        public static LazySingleton getInstance()
        {
            if(_instance == null)
            {
                _instance = new LazySingleton();
            }
            return _instance;

        }
    }
}
