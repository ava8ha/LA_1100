using System;
namespace LA_319_6908_KontrollstrukturenVerschachtelt
{
    class Aufgabe1
    {
        static void Main(String[] args)
        {
            // Verarbeitung 

            for (int h = 00; h < 24; h++)
            for (int m = 00; m < 60; m++)
            for (int s = 00; s < 60; s++)

                    // Ausgabe 
                    {
                        Console.WriteLine(h + ":" + m + ":" + s);
                    }
        }
    }
}                   /*int h = 00; 
                     * String res = h.ToString("00");
                     * int m = 00;
                     * string res1 = m.ToString("00");
                     * int s = 00;
                     * string res2 = s.ToString("00");*///System.Thread.Sleep(1000);


