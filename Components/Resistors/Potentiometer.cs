using System;
using SchematicEditor.Exceptions;

namespace SchematicEditor.Components.Resistors
{
    class Potentiometer : Resistor
    {
        private double[] ResistanceRange;


        public Potentiometer(double GivenResistance, double[] GivenResistanceRange) : base(GivenResistance)
        {
            SetResistanceRange(GivenResistanceRange);
        }


        public override double GetCurrentResistance() 
        { 
            return base.Resistance;
        }

        public override void SetCurrentResistance(double GivenResistance)
        {
            if (GivenResistance > this.ResistanceRange[1] || GivenResistance < this.ResistanceRange[0]) 
            {
                throw new InvalidResistanceException();
            }
            
            else
            {
                base.SetCurrentResistance(GivenResistance);
            }
        }

        public void SetResistanceRange(double[] GivenResistanceRange)
        {
            bool valid = true;

            if (GivenResistanceRange == null)
            {
                throw new InvalidResistanceRangeException();
            }

            if (GivenResistanceRange.Length != 2)
            {
                valid = false;
                throw new InvalidArrayLengthException();
            }

            if (GivenResistanceRange[0] > GivenResistanceRange[1])
            {
                valid = false;
                throw new InvalidResistanceRangeException();
            }

            this.ResistanceRange = valid ? GivenResistanceRange : this.ResistanceRange;
        }
    }
}
