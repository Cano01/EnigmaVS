using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaCore.Parts
{
    public class Entry
    {
        //Remember this class has to work as a dicctionary to be re configurable

        public List<string> Alphabet = new List<string>()
        {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        public Dictionary<string, int> Values  = new Dictionary<string, int>();

        public Entry() {
            for (int i = 0; i < 25; i++) 
            {
                Values.Add(Alphabet[i], i);
            }
        }
    }
}
