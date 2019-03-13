namespace WS_Prueba.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Persona")]
    public partial class Persona
    {
        
        public int ID { get; set; }
        public int DomicilioID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool Eliminado { get; set; }

    }
}
