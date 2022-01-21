using System;


namespace SchematicEditor.Exceptions
{
    public class InvalidResistanceRangeException : Exception
    {
        public InvalidResistanceRangeException(string Message="First element of resistance range must be lower than second") : base(Message)
        {
            
        }

        public InvalidResistanceRangeException(Exception Inner, string Message="First element of resistance range must be lower than second") : base(Message, Inner)
        {
            
        }
    }
}