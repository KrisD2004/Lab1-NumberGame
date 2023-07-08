namespace Lab1_Numbers
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StartSequence();
        }
        static void StartSequence()
        {
            int[] numberArray = new int[4]; // declaring array of four zeros
            int[] populateResult = Populate(numberArray); // calling populate method
            int sum = GetSum(populateResult);
            Console.WriteLine(sum);
            for (int i = 0; i < populateResult.Length; i++) //  loop through array and console.write elements
            {
                Console.Write(populateResult[i] + "");
            }
            Console.WriteLine();
            GetProduct(populateResult, sum);
            int product = GetProduct(populateResult, sum);
            GetQuotient(product);
        }
        static int[] Populate(int[] array)
        {
            //loop through the array and prompt user for values
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Give me a number");
                string userInput = Console.ReadLine();
                int number = Int32.Parse(userInput);
                array[i] = number;
            }
            return array;
        }
        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if (sum < 20)
            {
                throw new Exception("Number is too low");
            }
            return sum;
        }
        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Pick a random number 1 and {0}", array.Length);
            string randomIndex = Console.ReadLine();
            int randomIndexInt = Int32.Parse(randomIndex);
            randomIndexInt = randomIndexInt - 1;
            int randomNumber = array[randomIndexInt];
            Console.WriteLine("random number is: {0}", randomNumber);
            int product = randomNumber * sum;
            Console.WriteLine("this is the product: {0}", product);
            if (randomIndexInt < 0 || randomIndexInt >= array.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return product;
        }
        static decimal GetQuotient(int product)
        {
            // prompt the user for number to divide product by
            Console.WriteLine("Give me a number to divide the product by");
            string userInput = Console.ReadLine();
            int divisor = Int32.Parse(userInput);
            decimal quotient = product / divisor;
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            Console.WriteLine("This is the quotient: {0}", quotient);
            return quotient;
        }
    }
}





















