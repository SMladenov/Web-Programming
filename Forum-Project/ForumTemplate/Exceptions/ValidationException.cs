﻿namespace ForumTemplate.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : base()
        {
            
        }
        public ValidationException(string message) : base(message)
        {
            
        }
    }
}
