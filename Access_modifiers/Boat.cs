using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    class Boat
    {
        //fields
        public int numberOfPassengers;

        private string name;
        private double engineSize;

        //Properties
        // Properties might have different, more public facing 
        // names than functions
        // Similar to how properties can be set as read-only

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        //Constructors

        public Boat()
        {

        }

        public Boat(int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }

        //Methods

        public void Move()
        {
            Console.WriteLine(name + " moves forward.");
        }
        private double CalculateMPG()
        {
            double MPG = this.engineSize * .7d;

            return MPG;   
        }


    }
}
