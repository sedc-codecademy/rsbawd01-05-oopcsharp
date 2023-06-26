namespace C10E3.Models
{
    class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int CalculateArea()
        {
            return Length * Width;
        }
    }
}
