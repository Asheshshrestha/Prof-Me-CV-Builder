using System;
using System.ComponentModel.DataAnnotations;

namespace Prof_Me.Data.Models
{
    public class Accomplishment
    {
        public int Id { get; set; }
        [Display(Name = "Certificate Name")]
        public string CertificateName { get; set; }
        [Display(Name = "Got Date")]
        public DateTime GotDate { get; set; }
        public UserProfile User { get; set; }


    }
}
