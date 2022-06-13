using EnigmaCore.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaCore.Machine
{
    public class Enigma
    {
        public Entry Entry { get; set; }
        public Reflector Reflector { get; set; }
        public List<Rotor> Rotors { get; set; }
        public Dictionary<string,int> AbcToInt { get; set; }
        public Dictionary<int, string> IntToAbc { get; set; }

        public Enigma() {
            this.Rotors = new List<Rotor>();
            this.Reflector =  new Reflector();
            this.Entry = new Entry();
        }

        public string Encrypt()
        {
            return String.Empty;
        }

        public string Decrypt()
        {
            return String.Empty;
        }

        public void addRotor(Rotor NewRotor) 
        {
            this.Rotors.Add(NewRotor);
        }
    }
}
