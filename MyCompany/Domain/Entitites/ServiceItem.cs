using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entitites
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill service name")]
        [Display(Name = "Name service")] 
        public override string Title { get; set; }

        [Display(Name = "Short page description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Page description")]
        public override string Text { get; set; }
    }
}
