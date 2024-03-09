using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models.ORM
{
    public class AdminUser
    {
        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
