using System;

namespace Prof_Me.Data.Models
{
    public class Accomplishment
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public DateTime GotDate { get; set; }
        public UserProfile User { get; set; }


    }
}
