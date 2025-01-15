
namespace Task04
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real?? 0) + (Right?.Real ?? 0) ,
                Img = (Left?.Img ?? 0) + (Right?.Img ?? 0) ,
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Img = (Left?.Img ?? 0) - (Right?.Img ?? 0),
            };
        }
    }
}
