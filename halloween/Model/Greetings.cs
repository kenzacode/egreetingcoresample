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
        //NEED UNIQUE IDENIFIER 
        [Key]
        public int ID { get; set; }

        [DisplayName("Recipient Name")]
        [Display(Prompt = "e.g. ")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "You must enter between 3 to 100 characters")]
        public string toName { get; set; }

        [DisplayName("Your friend's email")]
        [Display(Prompt = "username@domain.com")]
        [Required(ErrorMessage = "Required")]
        public string toEmail { get; set; }

        [DisplayName("Subject")]
        [Required(ErrorMessage = "Required")]
        public string subject { get; set; }

        [DisplayName("Personalized Message")]
        [Required(ErrorMessage = "Required")]
        public string mesg { get; set; }

        [DisplayName("Sender's Name")]
        [Required(ErrorMessage = "Required")]
        public string fromName { get; set; }

        [DisplayName("Sender's Email")]
        [Required(ErrorMessage = "Required")]
        public string fromEmail { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool agree { get; set; }

        [Required(ErrorMessage = "Required")]
        public string createDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string createIP { get; set; }

        public string sendDate { get; set; }
        public string sendIP { get; set; }

        public string reCaptcha { get; set; }

    }

}
