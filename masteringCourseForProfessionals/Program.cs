namespace masteringCourseForProfessionals
{
    public class Program
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

            //var calc4 = new Calculator<char>();
            //Console.WriteLine($"Addition result :{calc4.Add('A', 'B')}");

            // ShowValueAndType<dynamic>(calc4);

            void ShowValueAndType<TVariable>(TVariable variable)
            {
                Console.WriteLine($"Type: {variable.GetType()}, Value: {variable}");
            }
            Sum(10, 20, ShowSumResult);
            ShowSumResult(12, "");
            SubTract(50, 20, (result) =>
                        {
                            Console.WriteLine($"Result is => :{result}");
                        }
            );// lambda expression
            Sum(10, 20, (result, message) =>
            {
                // function body
                Console.WriteLine($"Result is => :{result}");
            });
            void ShowSumResult(int result, string message)
            {
                Console.WriteLine($"Result is => :{result}");
            }
            void Sum(int x, int y, Action<int, string> showSumResult)
            {
                var result = x + y;
                showSumResult(result, "");
            }
            void SubTract(int x, int y, Action<int> showSumResult)
            {
                var result = x - y;
                showSumResult(result);
            }
            void Multiply(int x, int y)
            {
                Console.WriteLine($"Result of {x}* {y} is => :{x * y}");

            }
            void Add(int x, int y)
            {
                Console.WriteLine($"Result of {x}+ {y} is => :{x + y}");
            }
            var show = delegate (int result)
            {
                Console.WriteLine($"Result is => :{result}");
            };

            SubTract(40, 10, show);
            show(50);

            var cal = new CalculateDelegate((x, y) =>
            {
                Console.WriteLine($"Result is => :{x + y}");
            });

            var calDelegate1 = new CalculateDelegate(Multiply);
            calDelegate1(10, 20);
            var calDelegate2 = new CalculateDelegate(Add);
            calDelegate2(10, 20);
            calDelegate2(33, 20);
            calDelegate2(12, 12);
            calDelegate2.Invoke(12, 12);// equal or same result as calDelegate2(12, 12);

            //  delegate multi casting 

            var multcast = new CalculateDelegate(Add);
            multcast += Multiply;
            multcast(10, 20);
            multcast -= Multiply;


            var circle = new Circle();
            var circleDelegate = new Circle.CircleDelegate(circle.ShowInfo);
            circleDelegate += circle.CalculateArea;
            circleDelegate += circle.CalculatePrimeter;
            var delegateResult = circleDelegate.Invoke(10);
            //delegateResult will be the last method return value in the multi casting here is CalculatePrimeter
            circleDelegate -= circle.CalculatePrimeter;
            var delegateResult2 = circleDelegate(10);// delegateResult2= CalculateArea
            circleDelegate -= circle.ShowInfo;
            circleDelegate -= circle.CalculateArea;
            circleDelegate -= circle.CalculatePrimeter;
            if (circleDelegate != null)
            {
                circleDelegate(10);
            }
            else
            {
                Console.WriteLine("Delegate is null");
            }
            /*
               what is a delegate?
            -An object that refers to a method
               Why Use Delegates?
            1- Encapsulate a methods.
            2- used for Callbacks methods and events.
            3-can add one or more methods to a delegate instance or single event click.
            4- can be used for calling anonymous methods. 
             
            5- Pass methods as parameters.
            6- Declare a method signature.
            7- can remove one or more methods from a delegate instance or single event click.
            8-Asynchronous programming.

            delegate multi casting 
            -A delegate can point to multiple methods from single call of delegate 
            -all the added methods will be executed in order FIFO
            - Add methods to a delegate using + or += operator  
            - remove methods to a delegate using - or -= operator  
            important note  delegate multi casting should have void return type 


             */

            Console.WriteLine("Hello, World!");
        }
        public delegate void CalculateDelegate(int x, int y);

    }
}
