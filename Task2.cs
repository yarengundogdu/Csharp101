namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;

            y = y + 2;
            y += 2;  
            y /= 1;
            x *= 2;  
            
            //  ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("does not work");

            if (isSuccess || isCompleted)
                Console.WriteLine("works");

            if (isSuccess && !isCompleted)
                Console.WriteLine("works");
            
            // <,>,<=,>=,==,!=

            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result); 
          
            // *,/,+,-
            
            int num1 = 10;
            int num2 = 5;
            int result = num1 / num2;
            Console.WriteLine(result); 

            // %

            int result = 20 % 3;
            Console.WriteLine(c); 
        }
    }
}
