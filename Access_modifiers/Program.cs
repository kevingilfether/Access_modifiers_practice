using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //access modifiers
            //public -- can accessed from every part of the program
            //private -- can only be accessed from inside that class
            //protected -- can only be accessed from inside that class and descenedent classes
            //internal -- can only be accessed from that assembly (project)

            Boat boaty = new Boat(3, "Boaty", 18.6);
            boaty.Move();

            boaty.numberOfPassengers = 4;

            boaty.BoatInfo();
        }
    }
}
