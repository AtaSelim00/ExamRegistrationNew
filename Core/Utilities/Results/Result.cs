﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool succes, string message) : this(succes)
        {
            this.Message = message;


        }

        public Result(bool succes)
        {
            this.Succes = succes;


        }


        public bool Succes { get; }
        public string Message { get; }


    }
}
