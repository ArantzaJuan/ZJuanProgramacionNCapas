﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOperaciones" in both code and config file together.
    [ServiceContract]
    public interface IOperaciones
    {
        [OperationContract]
        int Suma(int numer1, int numero2);
        [OperationContract]
        int Resta(int numer1, int numero2);
        [OperationContract]
        int Multiplicacion(int numer1, int numero2);
        [OperationContract]
        int Division(int numer1, int numero2);
        [OperationContract]
        string Saludar(string nombre);
    }
}