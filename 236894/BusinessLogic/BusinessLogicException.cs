﻿using System;

namespace BusinessLogic
{
    public class BusinessLogicException : Exception
    {
        public BusinessLogicException(string message) : base(message)
        {
        }
    }
}