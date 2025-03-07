using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AM.applicationCore.Domain
{
    public class FullName
    {
       // [Owned]

        [MinLength(3, ErrorMessage = "doit etre min 3"), MaxLength(25, ErrorMessage = "doit etre max 25")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
