using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaCore.Parts
{
    public class Reflector
    {
        //Allow this class to be wired
        public Dictionary<int, int> Reflect = new Dictionary<int, int>();

        public Reflector() {
            for (int i = 0; i < 26; i++) {
                Reflect.Add(i, 25 - 1);
            }
        }

    }
}
