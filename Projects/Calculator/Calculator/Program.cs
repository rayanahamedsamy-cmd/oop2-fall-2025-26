namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select calculation method:");
            Console.WriteLine("1) Addition (+)");
            Console.WriteLine("2) Subtraction (-)");
            Console.WriteLine("3) Multiplication (*)");
            Console.WriteLine("4) Division (/)");
            Console.Write("Enter option (1-4): ");
            int Option = Convert.ToInt32(Console.ReadLine());
            if (Option >= 1 && Option <= 4) 
            {
                
            }

            Console.Write("Enter Number 1: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        Console.WriteLine(Num1 + Num2);
                        break;
                    case 2:
                        Console.WriteLine(Num1 - Num2);
                        break;
                    case 3:
                        Console.WriteLine(Num1 * Num2);
                        break;
                    case 4:
                        Console.WriteLine(Num1 / Num2);
                        break;
                }
            }
        }
    }
}