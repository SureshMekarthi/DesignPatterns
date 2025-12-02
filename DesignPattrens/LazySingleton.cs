using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazySingleton = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
        }

        //public static LazySingleton GetInstance()
        //{
        //    return lazySingleton.Value;
        //}

        public static LazySingleton GetInstance() => lazySingleton.Value;
      
    }
}
