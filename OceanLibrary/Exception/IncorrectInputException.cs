using System;

namespace Ocean
{
    public class IncorrectInputException : Exception
    {
        public string message = "Input is incorrect!";

        public IncorrectInputException()
        {

        }

        public IncorrectInputException(string v) : base("Input is incorrect!")
        {

        }
    }
}
