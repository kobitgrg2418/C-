namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            // TODO 1: declare a variable called userName that holds your name.
            //         Text needs the type string.
                                string userName = "Kobit";
            // TODO 2: declare a variable called luckyNumber holding your
            //         favourite single-digit number. A whole number is int.
                                int luckyNumber = 30;
            // TODO 3: print ONE line that reads exactly:
            //         Hello, <your name>! Your lucky number is <the number>.
            //         Use string interpolation, not the + operator.
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
        }
    }
}
