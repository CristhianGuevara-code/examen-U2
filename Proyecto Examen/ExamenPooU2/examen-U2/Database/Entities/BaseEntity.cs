using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace examen_U2.Database.Entities
{
    public class BaseEntity
    {
        [Key]       //llave primaria
        [Column("id")]  //nombre de columna que lleva el atributo
        public Guid identityNumber { get; set; }
    }
}
