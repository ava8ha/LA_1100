using System;
namespace LA_1100
{
    class Zahlenspiel
    {
        static void Main(string[] args)
        {
            string eingabe;
            int gerateneZahl = 0;
            bool benutzerHatsGecheckt = false;
            int versuche = 0;
            int geheimeZahl = new Random().Next(1, 100);
            while (gerateneZahl != geheimeZahl)
            {
                Console.WriteLine("Zahlen rate Spiel in welchem Sie eine generierte Zahl zwischen 1 und 100 eingeben. Wenn Sie richtig sind, haben Sie gewonnen, wenn nicht, haben Sie weitere 9 Versuche. Viel Glück!");
                do
                {

                    do
                    {
                        do
                        {
                            try
                            {
                                Console.Write("Zahl eingeben (1-100): ");
                                eingabe = Console.ReadLine();
                                gerateneZahl = Convert.ToInt32(eingabe);
                                benutzerHatsGecheckt = true;
                            }
                            catch
                            {
                                Console.WriteLine("Bitte nur Zahlen!");
                            }

                        } while (!benutzerHatsGecheckt);


                        if (gerateneZahl < geheimeZahl && gerateneZahl > 0)
                        {
                            Console.WriteLine("Zahl ist zu klein");
                        }
                        else if (gerateneZahl > geheimeZahl && gerateneZahl < 100)

                            if (gerateneZahl > geheimeZahl && gerateneZahl < 100)
                            {
                                Console.WriteLine("Zahl ist zu groß");
                            }

                        if (gerateneZahl < 0 | gerateneZahl > 100)
                        {
                            Console.WriteLine("Zahlen zwischen 1 und 100!");
                        }

                        versuche = versuche + 1;

                        if (gerateneZahl == geheimeZahl)
                        {
                            Console.WriteLine("Super! Du hast nur " + versuche + " Versuche benötigt");
                        }



                    } while (gerateneZahl != geheimeZahl && versuche < 10);
                } while (gerateneZahl != geheimeZahl && versuche < 10);

                if (gerateneZahl != geheimeZahl)
                {
                    Console.WriteLine("Sie haben verloren! Es wäre " + geheimeZahl + " gewesen.");
                }
                break;
            }
        }
    }

}


