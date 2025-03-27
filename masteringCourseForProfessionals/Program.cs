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
            ShowValueAndType(mySampleChar.Field);

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

            ShowValueAndType<dynamic>(calc4);

            void ShowValueAndType<TVariable>(TVariable variable)
            {
                Console.WriteLine($"Type: {variable.GetType()}, Value: {variable}");
            }
            Sum(10, 20, ShowSumResult);
            ShowSumResult(12, "");

            void ShowSumResult(int result, string message)
            {
                Console.WriteLine($"Result is => :{result}");
            }
            void Sum(int x, int y, Action<int, string> showSumResult)
            {
                var result = x + y;
                showSumResult(result, "");
            }


            Console.WriteLine("Hello, World!");
        }
    }
}
