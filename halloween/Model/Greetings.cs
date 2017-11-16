using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace halloween.Model
{
    public class Greetings
    {
        //NEED UNIQUE IDENIFIER FOR DATABASE
        [Key]
        public int? ID { get; set; }

        [DisplayName("Recipient Name")]
        [Display(Prompt = "e.g. Evelyn, mommy")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Oppise, is that correct?")]
        public string toName { get; set; }

        [DisplayName("Your friend's email")]
        [Display(Prompt = "look@thering.com")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Oppise, is that correct?")]
        public string toEmail { get; set; }

        [DisplayName("Subject")]
        [Display(Prompt = "He watched the tape...")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Oppise, is that correct?")]
        public string subject { get; set; }

        [DisplayName("Personalized Message")]
        [Display(Prompt = "She will show you...4 days.")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Oppise, is that correct?")]
        public string mesg { get; set; }

        [DisplayName("Sender's Name")]
        [Display(Prompt = "e.g. Samara Morgan")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Oppise, is that correct?")]
        public string fromName { get; set; }

        [DisplayName("Sender's email")]
        [Display(Prompt = "pleaselook@thering.com")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Oppise, is that correct?")]
        public string fromEmail { get; set; }


        public bool agree { get; set; }

    
        public string createDate { get; set; }

  
        public string createIP { get; set; }

        public string sendDate { get; set; }
        public string sendIP { get; set; }

        public string reCaptcha { get; set; }

    }

}
