using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    [Table("users")]
    public class User
    {
        [Column("_id")]
        [Key]
        public int Id { get; set; }

        [Column("user")]
        [Required]
        //[StringLength(12, MinimumLength =3)]
        public string Login { get; set; }

        [Column("passw")]
        [Required]
        //[MinLength(6)]
        
        public string Password { get; set; }
    }
}
