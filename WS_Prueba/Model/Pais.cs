using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WS_Prueba.Model
{
    [Table("Pais")]
    public partial class Pais
    {

        public int ID { get; set; }


        public string Nombre { get; set; }

        public string abreviatura { get; set; }
    }
}