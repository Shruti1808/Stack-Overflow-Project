using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
   [Table("Questions")]
    public class Question
    {
       [Key]
        public int id { get; set; }
        public string Description { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}
