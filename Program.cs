
namespace c_SimpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            Console.WriteLine("Choose operation: '+','-','*','/'");
            string action = Console.ReadLine();
            Console.WriteLine("Input num 1:");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Input num 2:");
            secondValue = double.Parse(Console.ReadLine());

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
            else if(action == "/")
            {
                Console.WriteLine(firstValue / secondValue);
            }
            else { Console.WriteLine("ERROR!!!"); }
        }

    }       
}
