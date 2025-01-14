﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Plumberz.BL.Exceptions.Common;

public class NotFoundException<T> : Exception,IBaseException
{
    public int Code => StatusCodes.Status404NotFound;
    public string ErrorMessage { get; }
    public NotFoundException() :  base(typeof(T).Name + " not found!")
    {
        ErrorMessage = typeof(T).Name + " not found!";
    }
    public NotFoundException(string msg) : base(msg) 
    {
        ErrorMessage = msg;    
    }
}
