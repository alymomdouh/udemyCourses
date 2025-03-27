namespace masteringCourseForProfessionals
{
    public class Circle
    {
        /*
        public delegate void CircleDelegate(double radius);
        public void CalculateArea(double radius)
        {
            Console.WriteLine($"Circle Area is \"{radius * radius * Math.PI}\"");
        }
        public void CalculatePrimeter(double radius)
        {
            Console.WriteLine($"Circle Primeter is \"{2 * radius * Math.PI}\"");
        }
        public void ShowInfo(double radius)
        {
            Console.WriteLine($"Circle with radius \"{radius}\"");
        }
        */
        public delegate int CircleDelegate(double radius);
        public int CalculateArea(double radius)
        {
            Console.WriteLine($"Circle Area is \"{radius * radius * Math.PI}\"");
            return 2;
        }
        public int CalculatePrimeter(double radius)
        {
            Console.WriteLine($"Circle Primeter is \"{2 * radius * Math.PI}\"");
            return 1;
        }
        public int ShowInfo(double radius)
        {
            Console.WriteLine($"Circle with radius \"{radius}\"");
            return 0;
        }
    }
}
