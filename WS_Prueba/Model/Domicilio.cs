using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Prueba.Model
{
    public class Domicilio
    {
        public int ID { get; set; }
        public int LocalidadID { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string CodigoPostal { get; set; }
        public string Referenciaas { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool Eliminado { get; set; }
    }
}