namespace masteringCourseForProfessionals
{
    /*
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        } 
    }
    */
    internal class Calculator<T>
    {
        public T Add(T a, T b) => (dynamic)a + (dynamic)b;
    }
}
