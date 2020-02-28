namespace Prof_Me.Data.Models
{
    public class ImageFile
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public UserProfile user { get; set; }
    }
}
