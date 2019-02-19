namespace WS_Prueba.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Persona")]
    public partial class Persona
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(20)]
        public string Nombre { get; set; }

        public int? Edad { get; set; }
    }
}
