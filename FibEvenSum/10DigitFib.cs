namespace CodeChallenges2
{
    internal class _10DigitFib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- 10 Digit Fibonacci -----\n\n");

            //The Fib sequence is defined by the recurrence relatuion:
            //Fn = Fn-1 + Fn-2,
            //where F1 = 1, F2 = 2, F3 = 2...
            //and F12 = 144. F12 is the first term to contain 3 digits
            //What is the index of the first term in the fib sequence to contain 10 digits?

            bool exit = false;
            List<int> fibSeq = new List<int>() { 1, 2 };
            int start = 1;
            int fibNbr = start;
            int digNbr = fibNbr.ToString().Length;
            int i = 10;

            do
            {
                if (digNbr < 10)
                {
                    fibNbr = fibSeq[fibSeq.Count - 1] + fibSeq[fibSeq.Count - 2];
                    fibSeq.Add(fibNbr);
                    digNbr = fibNbr.ToString().Length;
                    i += 1;
                    Console.WriteLine($"The index is: {i}");
                }
                else
                {
                    exit = true;
                }
            } while (exit);
           


        }//end Main()
    }//end class
}//end namespace
