using System;
using SchematicEditor.Exceptions;

namespace SchematicEditor.Components.Resistors
{
    class Resistor
    {
        protected double Resistance;


        public Resistor(double GivenResistance)
        {
            SetCurrentResistance(GivenResistance);
        }


        public virtual double GetCurrentResistance() 
        { 
            return this.Resistance;
        }

        public virtual void SetCurrentResistance(double GivenResistance) 
        {
            bool valid = true;

            if (GivenResistance == null)
            {
                valid = false;
                throw new InvalidResistanceException();
            }
            
            this.Resistance = valid ? GivenResistance : this.Resistance;
        }
    }
}
