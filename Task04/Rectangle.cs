
namespace Task04
{
    internal class Rectangle
    {
        public int width {  get; set; }
        public int height { get; set; }
        public Rectangle()
        {
            width = 0;
            height = 0;
        }
        public Rectangle(int W , int H)
        {
             width= W;
            height= H;
        }
        public Rectangle(int value)
        {
            width = value;
            height = value;
        }
    }
}
