using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitjat.

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
                sum1 = sum1 + userScore;
                sum2 = sum2 + cpuScore;
            }
            Console.WriteLine($"User wins {sum1} times.");
            Console.WriteLine($"Cpu wins {sum2} times");

            if(sum1 > sum2)
            {
                Console.WriteLine("User is the winner!");
            }
            else
            {
                Console.WriteLine("Cpu is the winner!");
            }


        }
    }
}
