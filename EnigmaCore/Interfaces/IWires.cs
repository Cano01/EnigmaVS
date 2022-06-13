using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaCore.Parts;

namespace EnigmaCore.Interfaces
{
    public interface IWires
    {

        /// <summary>
        /// Will set al the wires in the dictionary according to given faces
        /// </summary>
        /// <param name="InternarFace">Some text</param>
        /// <param name="ExternalFace"> Some text</param>
        public void WireRotor(List<int> InternarFace, List<int> ExternalFace);

        // will return the next wire connection
        public void UseWire(int UsingWire, List<int> InternalFace, List<int> ExternalFace, RotorMode Mode, out int Pin);
    }
}
