using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorEx
{
    public class Atom
    {
        public int atomProtons; //properties
        public int atomElectrons; //properties

        public Atom()
        {
            //default control
        }
        public Atom(int electrons, int protons)
        {
            Protons = protons;
            Electrons = electrons;
        }

        public int Protons {
            get => atomProtons; 
            set => atomProtons = value; 
        }
        
        public int Electrons {
            get => atomElectrons; 
            set => atomElectrons = value; 
        }

        ~Atom()
        {
            Console.WriteLine("Goodbye");
            Console.WriteLine($"Current number of protons: {atomProtons}");
            Console.WriteLine($"Current number of electrons: {atomElectrons}");
            Console.ReadLine();
        }

    }
}
