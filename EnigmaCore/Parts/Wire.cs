using EnigmaCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaCore.Parts;

namespace EnigmaCore.Parts
{
    public class Wire : IWires
    {

        public Wire() { }
            


        public void WireRotor(List<int> InternarFace, List<int> ExternalFace) {
            var i = 1;
        }

        public void UseWire(int UsingWire, List<int> InternalFace, List<int> ExternalFace, RotorMode Mode, out int Pin) {
            Pin = 0;
            if (Mode == RotorMode.Inputing)
            {
                foreach (int WiredLetter in ExternalFace)
                {
                    if (UsingWire == WiredLetter) return;
                    else Pin++;
                }
            }
            else 
            {
                foreach (int WiredLetter in InternalFace)
                {
                    if (UsingWire == WiredLetter) return;
                    else Pin++;
                }
            }
        }
    }
}
