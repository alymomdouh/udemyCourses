namespace masteringCourseForProfessionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            var mySampleInt = new Sample<int>();
            mySampleInt.Field = 1;
            Console.WriteLine(mySampleInt.ShowInfo());



            var mySampleChar = new Sample<char>();
            mySampleChar.Field = 'A';
            Console.WriteLine(mySampleChar.ShowInfo());

            Console.WriteLine("Hello, World!");
        }
    }
}
