using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace WS_Prueba.IWS
{
    [ServiceContract]
    public interface IWS_Pais
    {
        [OperationContract]
        Model.Pais ObtenerPais(int PaisID);

        [OperationContract]
        Model.Pais BuscarPais(string Nombre);

        [OperationContract]
        string GuardaPais(string Nombre, string Abreviatura);
    }
}