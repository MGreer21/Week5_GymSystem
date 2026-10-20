using System;
using System.Collections.Generic;
using System.Text;

namespace GmySystem
{
    public class Equipment
    {
        // private fields 

        private int equipmentid;
        private string name;
        private bool isavailable;


        // public properties

        public int EquipmentID
        {
            get { return equipmentid; }
            private set
            {
                if (value > 0)
                {
                    equipmentid = value;
                }
                else
                {
                    Console.WriteLine("Error: equipment ID must be greater then zero.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                // Ensure name doesnt contain numbers
                if (!string.IsNullOrEmpty(value) && !value.Any(char.IsDigit))
                {
                    name = value;

                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }

        public bool IsAvailable
        {
            get { return isavailable; }
            set { isavailable = value; }
        }

        // constructor

        public Equipment(int eqipmentID, string name, bool isAvailable)
        {
            EquipmentID = equipmentid;
            Name = name;
            isavailable = isAvailable;
        }

    }
}
