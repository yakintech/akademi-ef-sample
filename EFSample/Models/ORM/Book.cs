using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models.ORM
{
    public class Book : BaseModel
    {

        [MaxLength(100)]
        public string? Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Writer { get; set; }

    }
}
