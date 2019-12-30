using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class singel
    {
        private string data;
        private static singel instance = null;
        public static singel Instance
        {
            get {
                if (instance == null) {
                    instance = new singel();
                }
                return instance;
                    }
        }
        private singel()
        {
            data = "hello world";
        }

        public string getdata()
        {
            return data;
        }
    }
}
