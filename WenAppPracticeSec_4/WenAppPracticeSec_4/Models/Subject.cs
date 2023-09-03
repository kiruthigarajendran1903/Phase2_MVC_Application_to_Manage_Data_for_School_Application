using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WenAppPracticeSec_4.Models
{
 
        [Table("SubTable")]
        public class Subject
        {
            [Key]
            public int SubjectId { get; set; }
            [Required]
            public string SubjectName { get; set; }

            public virtual Student Student { get; set; }

        }
    }