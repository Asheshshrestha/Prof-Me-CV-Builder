namespace Prof_Me.Data.Models
{
    public class Language
    {
        public int Id { get; set; }
        public int LanguageName { get; set; }
        public UserProfile User { get; set; }

    }
}
