using System;


namespace SchematicEditor.Exceptions
{
    public class InvalidArrayLengthException : Exception
    {
        public InvalidArrayLengthException(string Message="Resistance array can only contain 2 elements") : base(Message)
        {
            
        }

        public InvalidArrayLengthException(Exception Inner, string Message="Resistance array can only contain 2 elements") : base(Message, Inner)
        {
            
        }
    }
}