using EnigmaCore.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaCore.Interfaces
{
    internal interface IRotor
    {

        public int Mode { get; set; }

        public int Rate { get; set; }

        public List<int> InternalFace { get; set; }

        public List<int> ExternalFace { get; set; }

        public string Rotate(string input);

    }
}
