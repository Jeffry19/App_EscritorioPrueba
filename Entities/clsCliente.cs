using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public enum sexo //Tipo de dato limitado solo M o F para utilizarno en la propiedad genero
    {
        M,F
    }

   
    [Table("tbCliente")]
    public class clsCliente
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //LO que hace es que sea autoincrental el id en la base de datos
        [Required]
        public int id { get; set; }

        [Required] //que no acepte nullos
        [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
        [RegularExpression(@"a-zA-Z\s]+$", ErrorMessage ="El nombre solo debe contener letras, no numeros ni caracteres especiales")]
        public string nombre { get; set; }

        [Required] //que no acepte nullos
        [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
        [RegularExpression(@"a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras, no numeros ni caracteres especiales")]
        public string apellido1 { get; set; }

        [Required] //que no acepte nullos
        [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
        [RegularExpression(@"a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras, no numeros ni caracteres especiales")]
        public string apellido2 { get; set; }

        [Required]
        public sexo genero { get; set; }

        [Required]
        public DateTime fechaNac { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="El email no contiene un formato valido")]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage ="El email no tiene un formato valido")]
        public string email { get; set; }

        
        public bool estado { get; set; }= true;

        public clsCliente() { }
    }
}
