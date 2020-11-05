using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNummer = new Random();

            int[] personKort = new int[11];

            int[] delarKort = new int[11];

            personKort[1] = randNummer.Next(2, 11);

            personKort[2] = randNummer.Next(2, 11);

            delarKort[1] = randNummer.Next(2, 11);

            delarKort[2] = randNummer.Next(2, 11);

            Console.WriteLine($"Dina två kort var {personKort[1]} och {personKort[2]} och din summa är nu {personKort[1] + personKort[2]}," +
                $" delarens ena kort var {delarKort[1]} och det andra är okänt " +
                $"\n Vill du fortsätta? Skriv Ja eller Nej");

            string fortsättning = Console.ReadLine();

            int summaPerson = personKort[1] + personKort[2];
            int summaDelare = delarKort[1] + delarKort[2];


            for (int i = 0; i < personKort.Length; i++)
            {

                if (fortsättning == "Ja")
                {

                    personKort[i] = randNummer.Next(2, 11);



                    if (personKort[i] == 11)
                    {


                        Console.WriteLine("Du fick ett \"Ess\" välj om det ska vara en 1:a eller en 11:a ");
                        int essVal = int.Parse(Console.ReadLine());
                        if (essVal == 11)
                        {
                            personKort[i] = 11;
                        }
                        if (essVal == 1)
                        {
                            personKort[i] = 1;
                        }

                    }
                    summaPerson = summaPerson + personKort[i];
                    Console.WriteLine($" {personKort[i]} Din totalsumma är nu {summaPerson} vill du fortsätta? skriv Ja eller Nej");
                    fortsättning = Console.ReadLine();
                }

                if (summaPerson > 21)
                {
                    break;
                }
            }

            if ((summaPerson <= 21))
            {


                Console.WriteLine($"Delarens två kort är {delarKort[1]} och {delarKort[2]} och har en summa på {summaDelare}. \n" +
                $"tryck \"ENTER\" för att se delarens kort");
                Console.ReadLine();

                for (int i = 2; i < delarKort.Length; i++)
                {
                    delarKort[i] = randNummer.Next(2, 11);

                    summaDelare = summaDelare + delarKort[i];

                    Console.WriteLine($" {delarKort[i]} , Summan är nu {summaDelare} ");

                    if (summaDelare > 21 || (summaDelare > summaPerson && summaDelare <= 21))
                    {
                        break;
                    }

                }

                if (summaDelare > 21 && summaPerson <= 21)
                {
                    Console.WriteLine($"Du vann, delare fick {summaDelare} som summa ");
                }

                else if (summaDelare <= 21 || (summaDelare > summaPerson && summaDelare <= 21))
                {
                    Console.WriteLine("Tyvärr delaren var närmare 21 och du förlorade");
                }

                else if (summaPerson >= summaDelare)
                {
                    Console.WriteLine("Tyvärr du fick över 21 och förlorade ");
                }

            }


            else if (summaPerson > 21)
            {
                Console.WriteLine("Du fick över 21 och förlorade");
            }

            Console.ReadLine();
































        }
    }
}



                
                



