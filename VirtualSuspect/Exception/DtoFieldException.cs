﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSuspect.Exception
{
    [Serializable]
    class DtoFieldException : System.Exception
    {

        public DtoFieldException(string message) : base(message)
        {

        }

    }
}
