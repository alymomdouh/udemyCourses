namespace masteringCourseForProfessionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-------------Generic Classes ------------------------");

            var mySampleInt = new Sample<int>();
            mySampleInt.Field = 1;
            Console.WriteLine(mySampleInt.ShowInfo());



            var mySampleChar = new Sample<char>();
            mySampleChar.Field = 'A';
            Console.WriteLine(mySampleChar.ShowInfo());


            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-------------Using Calculator -----------------------");

            //var calc1 = new Calculator();
            //Console.WriteLine($"Addition result :{calc1.Add(12, 10)}");
            //Console.WriteLine($"Addition result :{calc1.Add(12.4, 10.7)}");

            var calc2 = new Calculator<int>();
            Console.WriteLine($"Addition result :{calc2.Add(12, 10)}");

            var calc3 = new Calculator<double>();
            Console.WriteLine($"Addition result :{calc3.Add(12.4, 10.7)}");

            var calc4 = new Calculator<char>();
            Console.WriteLine($"Addition result :{calc4.Add('A', 'B')}");

            Console.WriteLine("Hello, World!");
        }
    }
}
