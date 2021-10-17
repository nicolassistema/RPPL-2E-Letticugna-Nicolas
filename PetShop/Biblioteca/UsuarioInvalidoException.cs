﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException()
        {
        }

        public UsuarioInvalidoException(string message) : base(message)
        {
        }

        public UsuarioInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        //public override string Message
        //{
        //    get
        //    {
        //        return "Nombre invalido";
        //    }
        //}


    }
}
