using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GmySystem
{
    public class ResistanceMachine : Equipment
    {

        private int weightStackMax; 


        public int WeightStackMax
        {
            get { return weightStackMax; }
            private set
            {
                if (value < 0)
                {
                    weightStackMax = value;
                }
                else
                {
                    Console.WriteLine("Error: Equipment max weight must be greater then zero.");
                }
            }
        }

        public ResistanceMachine(int eqipmentID, string name, bool isAvailable, int weightStackMax)
           : base (equipmentID, name, isAvailable)
        { 
    this.WeightStackMax = weightStackMax; 
        }


    }
}
