
namespace c_SimpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape) 
            {
            double firstValue, secondValue;
            Console.WriteLine("Choose operation: '+','-','*','/'");
            string action = Console.ReadLine();
                try
                {
            Console.WriteLine("Input num 1:");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Input num 2:");
            secondValue = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Its nut a number, please try again");
                    Console.ReadLine();
                    continue;
                }

            //switch (action)
            //{
            //    case "+": 
            //        Console.WriteLine(firstValue + secondValue);
            //    break;
            //    case "-":
            //        Console.WriteLine(firstValue - secondValue); 
            //    break;
            //    case "*":
            //        Console.WriteLine(firstValue * secondValue);
            //    break;
            //    case "/":
            //        Console.WriteLine(firstValue / secondValue);
            //    break;
                
            //    default:
            //        Console.WriteLine("Error!!");
            //    break;
            //}
            if (action == "+")
            {
                Console.WriteLine(firstValue + secondValue);
            }
            else if (action == "-")
            {
                  Console.WriteLine(firstValue - secondValue);
            }
            else if (action == "*")
            {
                Console.WriteLine(firstValue * secondValue);
            }
                else if (action == "/")
            {
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Devisionby 0 is forbidden, please try againe");
                    }
                Console.WriteLine(firstValue / secondValue);
            }
            else { Console.WriteLine("ERROR!!!"); }
                Console.WriteLine("If your are end press ECS: ");
                               
            }
        }

    }       
}
