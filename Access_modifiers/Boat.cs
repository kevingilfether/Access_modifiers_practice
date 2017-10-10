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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        //Constructors

        public Boat()
        {

        }

        //Methods

        public void Move()
        {

        }
        private double CalculateMPG()
        {
            
        }


    }
}
