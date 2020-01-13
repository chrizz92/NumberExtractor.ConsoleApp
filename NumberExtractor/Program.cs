using System;

namespace NumberExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSentence;
            long includedNumber = 0;

            Console.WriteLine("Nummern extrahieren");
            Console.WriteLine("===================");
            Console.Write("Bitte Satz eingeben: ");
            inputSentence = Console.ReadLine();

            for (int i = 0; i < inputSentence.Length; i++)
            {
                if(inputSentence[i] >= '0' && inputSentence[i] <= '9')
                {
                    includedNumber *= 10;
                    includedNumber += inputSentence[i] - 48;   
                }
            }

            Console.WriteLine("Die enthaltene Zahl ist {0}. Das Doppelte der Zahl lautet {1} ", includedNumber, includedNumber * 2);


        }
    }
}
