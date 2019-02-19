using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_Prueba
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersonas
    {
        [OperationContract]
        Persona ObtenerPersona(string Identificacion);

        [OperationContract]
        Persona BuscarPersona(int PersonaID);

        [OperationContract]
        string GuardarPersona(string Identidicador, string Nombre, int Edad);
    }

    [DataContract]
    public class Persona:BaseRespuesta
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Edad { get; set; }
        public string Secreto { get; set; }
    }
    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public string MensajeRespuesta { get; set; }
        [DataMember]
        public string Error { get; set; }
    }

    
}
