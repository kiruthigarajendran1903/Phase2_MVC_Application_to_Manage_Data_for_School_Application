using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WenAppPracticeSec_4.Models
{
    [Table("ClTable")]
    public class Classes
    {
 
            [Key]
            public int ClassId { get; set; }
            [Required]
            public string ClassName { get; set; }

            public virtual Student Student { get; set; }

        }
    }

