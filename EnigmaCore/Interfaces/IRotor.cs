﻿using EnigmaCore.Parts;
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

        public IEnumerable<string> InternalFace { get; set; }

        public IEnumerable<string> ExternalFace { get; set; }

        public IWires wires { get; set; }

        public void Rotate();



    }
}
