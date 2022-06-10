using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaCore.Interfaces;

namespace EnigmaCore.Parts
{
    public class Rotor : IRotor
    {
        public int Mode { get; set; }

        public int Rate { get; set; }

        public IEnumerable<string> InternalFace { get; set; }

        public IEnumerable<string> ExternalFace { get; set; }

        public IWires wires { get; set; }

        public void Rotate() { }
        public Rotor(int RotorMode) {
            this.Mode = RotorMode;
        }
        


    }
}
