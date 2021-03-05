using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entitites
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name page (header)")] 
        public override string Title { get; set; } = "Info page";

        [Display(Name = "Page content")]
        public override string Text { get; set; } = "Conent fills by admin";
    }
}
