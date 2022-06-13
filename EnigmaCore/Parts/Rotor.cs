using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaCore.Interfaces;

namespace EnigmaCore.Parts
{
    public enum RotorMode { 
        Inputing,
        OutPuting
    }

    public class Rotor : IRotor
    {
        public int Mode { get; set; }

        public int Rate { get; set; }

        public List<int> InternalFace { get; set; }

        public List<int> ExternalFace { get; set; }

        public IWires Wiring { get; set; }

        public string Rotate(string input) {
            //move faces
            //wirer
            return String.Empty;
        }



        public Rotor(
            List<int> RotorInternalFace, 
            List<int> RotorExternalFace, 
            int RotorMode = 0, 
            int RotorRate = 0)  
        {
            this.Mode = RotorMode;
            this.Rate = RotorRate;
            this.InternalFace = RotorInternalFace;
            this.ExternalFace = RotorExternalFace;
            this.Wiring = new Wire();
            this.Wiring.WireRotor(this.InternalFace, this.ExternalFace);
        }
        
        

    }
}
