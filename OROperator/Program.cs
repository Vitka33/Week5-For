using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma kasutaja tunnust ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsooliss kuvatakse "Tere tuelmast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            //Or ||
            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false


            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemat!"); 
            }
        }
    }
}
