﻿using System;

namespace BuenaHealth.Data.Exceptions
{
    [Serializable]
    public class ChildObjectNotFoundException : Exception
    {
        public ChildObjectNotFoundException(string message)
            : base(message)
        {
        }
    }

}
