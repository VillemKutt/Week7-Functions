﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada oma eesnime
            //programm kuvab kasutja eesnime pikkust
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem kui 3 rida koodi



            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();


            GetUserNameData(userName);

        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");



            for (int i = userInput.Length - 1; i >= 0; i--)
            {


                Console.Write(userInput[i]);

            }
        }
}
