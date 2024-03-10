using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models.ORM
{
    [Table("Countries")]
    public class Country : BaseModel
    {
        [Key]
        public int CId { get; set; }

        [Required]
        public decimal Price { get; set; }


        public string Name { get; set; }
    }
}
