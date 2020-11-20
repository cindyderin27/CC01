using System;


namespace CC01.BLL
{
    
   public class TypingException : Exception
    {
        public TypingException()
        {
        }

        public TypingException(string message) : base(message)
        {
        }

        public TypingException(string message, Exception innerException) : base(message, innerException)
        {
        }

       
    }
}