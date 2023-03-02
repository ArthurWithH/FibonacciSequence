namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = 0, holder = 1, fibonacciSum = 0;

            Console.Write("Informe o número a ser pesquisado na sequência de Fibonacci: ");
            int answer = int.Parse(Console.ReadLine());

            while(fibonacciSum < answer)
            {
                fibonacciSum = lastNumber + holder;
                lastNumber = holder;
                holder = fibonacciSum;
            }

            if (fibonacciSum == answer)
            {
                Console.WriteLine("Este número pertence a sequência!");
            }
            else
            {
                Console.WriteLine("Este número não pertence a sequência!");
            }
        }
    }
}