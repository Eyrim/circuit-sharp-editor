using System;


namespace SchematicEditor.Exceptions
{
    public class InvalidResistanceException : Exception
    {
        public InvalidResistanceException(string Message="Resistance must be non null, and within current resistance range constraints") : base(Message)
        {
            
        }

        public InvalidResistanceException(Exception Inner, string Message="Resistance must be non null, and within current resistance range constraints") : base(Message, Inner)
        {
            
        }
    }
}