

namespace ImageByutefire.Models
{
    public class ImageByutefireModel
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public Effects Effect { get; set; }
        public decimal Radious { get; set; }
        public int Hight { get; set; }
        public int Width { get; set; }

    }
    public enum Effects 
    {
        effct1, effct2, effct3, effct4,

    }

}
