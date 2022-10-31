namespace CodeChallenges2
{
    internal class LongCollatz
    {
        static void Main(string[] args)
        {
            //The following iterative sequence is defined for the set of positive integers:

            //n -> n/2 (n is even)
            //n -> 3n + 1 (n is odd)

            //Using the rule above and starting with 13, we generate the following sequence:
            //13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1

            //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
            //Although it has not been proven yet (Collatz Problem), it is thought that all starting numbers
            //finish at 1.
            //Which starting number, under 1,000, produces the longest chain?

            Console.WriteLine("----- Longest Collatz -----\n\n");

            var rangeNbrs = Enumerable.Range(13, 1_000).ToList();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (var x in rangeNbrs)
            {
                int newNbr = x;
                int count = 0;
                bool exit = false;

                do
                {
                    if (newNbr % 2 == 0 && newNbr > 1)
                    {
                        newNbr = newNbr / 2;
                        count += 1;


                    }
                    else if (newNbr % 2 == 1 && newNbr > 1)
                    {
                        newNbr = (3 * newNbr) + 1;
                        count += 1;

                        

                    }
                    else if (newNbr == 1)
                    {
                        count+=1;
                        dictionary.Add(x, count);
                        exit = true;
                    }

                    Console.WriteLine(x);
                }while(exit);
            }//end foreach


        }//end Main()
    }//end class
}//end namespace
