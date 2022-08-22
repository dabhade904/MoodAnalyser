﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalayser
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,NO_SUCH_FIELD_NO_SUCH_METHOD,NO_SUCH_CLASS,OBJECT_CREATION_ISSUE
        }

        private readonly ExceptionType type;   
        public MoodAnalyserException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type; 
        }
    }
}
