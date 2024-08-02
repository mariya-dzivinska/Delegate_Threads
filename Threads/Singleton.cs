using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object lockobj = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            lock (lockobj)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }

            return _instance;
        }
    }
}
