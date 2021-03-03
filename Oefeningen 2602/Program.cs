using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_2602
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Oefening: ");
            string oefening = Console.ReadLine();

            switch (oefening)
            {
                case "1":

                    Console.WriteLine("Oefening 1:\n");

                    Console.Write("Op een schaal van 1-3, wat is je niveau?: ");
                    string antwoord = Console.ReadLine();

                    switch (antwoord)
                    {
                        case "1": Console.WriteLine("Je bent een Junior"); break;
                        case "2": Console.WriteLine("Je bent een Medior"); break;
                        case "3": Console.WriteLine("Je bent een Senior"); break;
                    }
                    break;

                case "2":

                    Console.WriteLine("Oefening 2:\n");
                    Console.Write("Maand: ");
                    string maand = Console.ReadLine();

                    switch (maand)
                    {
                        case "1": Console.WriteLine("Deze maand is Januari"); break;
                        case "2": Console.WriteLine("Deze maand is Februari"); break;
                        case "3": Console.WriteLine("Deze maand is Maart"); break;
                        case "4": Console.WriteLine("Deze maand is April"); break;
                        case "5": Console.WriteLine("Deze maand is Mei"); break;
                        case "6": Console.WriteLine("Deze maand is Juni"); break;
                        case "7": Console.WriteLine("Deze maand is Juli"); break;
                        case "8": Console.WriteLine("Deze maand is Augustus"); break;
                        case "9": Console.WriteLine("Deze maand is September"); break;
                        case "10": Console.WriteLine("Deze maand is Oktober"); break;
                        case "11": Console.WriteLine("Deze maand is November"); break;
                        case "12": Console.WriteLine("Deze maand is December"); break;
                        default: Console.WriteLine("Ongeldige input, getal moet tussen 1 - 12 zijn"); break;
                    }
                    break;

                case "3":

                    Console.WriteLine("Oefening 3:\n");
                    Console.Write("Maand: ");
                    string maand3 = Console.ReadLine().ToLower();

                    switch (maand3)
                    {
                        case "januari": Console.WriteLine("Deze maand is de 1st maand"); break;
                        case "februari": Console.WriteLine("Deze maand is de 2de maand"); break;
                        case "maart": Console.WriteLine("Deze maand is 3de maand"); break;
                        case "april": Console.WriteLine("Deze maand is 4de maand"); break;
                        case "mei": Console.WriteLine("Deze maand is 5de maand"); break;
                        case "juni": Console.WriteLine("Deze maand is 6de maand"); break;
                        case "juli": Console.WriteLine("Deze maand is 7de maand"); break;
                        case "augustus": Console.WriteLine("Deze maand is 8ste maand"); break;
                        case "september": Console.WriteLine("Deze maand is 9de maand"); break;
                        case "oktober": Console.WriteLine("Deze maand is 10de maand"); break;
                        case "november": Console.WriteLine("Deze maand is 11de maand"); break;
                        case "december": Console.WriteLine("Deze maand is 12de maand"); break;
                        default: Console.WriteLine("Ongeldige input, maand niet herkend"); break;
                    }
                    break;

                case "4":

                    Console.WriteLine("Oefening 4:\n");
                    Console.Write("Jaar: ");
                    string jaar = Console.ReadLine();

                    switch (jaar)
                    {
                        case "1302": Console.WriteLine("Het jaar van Guldensporenslag"); break;
                        case "1492": Console.WriteLine("Het jaar waarin Christopher Columbus vertrekt"); break;
                        case "1830": Console.WriteLine("Het jaar waarin de Indianen worden uitgeroeid"); break;
                        case "1914": Console.WriteLine("Start van de Eerste wereld oorlog"); break;
                        case "1918": Console.WriteLine("Einde van de Eerste wereld oorlog"); break;
                        case "1939": Console.WriteLine("Start van de Tweede wereld oorlog"); break;
                        case "1945": Console.WriteLine("Einde van de Tweede wereld oorlog"); break;
                        case "2001": Console.WriteLine("9/11"); break;

                        default: Console.WriteLine("Ongeldige jaar, geen gegevens gevonden"); break;
                    }
                    break;
                case "5":

                    Console.WriteLine("Oefening 5:\n");
                    Console.Write("Letter: ");
                    string letter = Console.ReadLine().ToUpper();

                    switch (letter)
                    {
                        case "A": Console.WriteLine("Dat is een klinker"); break;
                        case "E":
                        case "I":
                        case "O":
                        case "Y":
                        case "U": Console.WriteLine("Dat is een klinker"); break;
                        case "B":
                        case "C":
                        case "D":
                        case "F":
                        case "G":
                        case "H":
                        case "J":
                        case "K":
                        case "L":
                        case "M":
                        case "N":
                        case "P":
                        case "Q":
                        case "R":
                        case "S":
                        case "T":
                        case "V":
                        case "W":
                        case "X":
                        case "Z": Console.WriteLine("Dat is een medeklinker"); break;
                        default: Console.WriteLine("Ongeldige input"); break;
                    }
                    break;

                case "6":

                    Console.WriteLine("Oefening 6:\n");
                    Console.Write("Jaartal: ");

                    int jaartal = Convert.ToInt32(Console.ReadLine());

                    if ((jaartal % 4 == 0 && jaartal % 100 != 0) || (jaartal % 4 == 0 && jaartal % 400 == 0))
                    {
                        Console.WriteLine("Dat is een schrikkeljaar");

                    }
                    else
                    {
                        Console.WriteLine("Dat is geen schrikkeljaar");
                    }

                    break;

                case "7":

                    Console.WriteLine("Oefening 7:\n");
                    Console.WriteLine("Hallo! Ik ben een chatbox! Wat kan ik vandaag voor je doen?");
                    Console.WriteLine("1. Ik heb hulp nodig bij mijn programmeerlessen!");
                    Console.WriteLine("2. Ik verveel me.");
                    Console.WriteLine("3. Niets, toch bedankt.");
                    Console.Write("Antwoord: ");

                    string antwoord7 = Console.ReadLine();

                    switch (antwoord7)
                    {
                        case "1":
                            Console.Write("Oei heb je al geprobeerd om het op te zoeken op het internet?\n1. Ja, tevergeefs.\n2. Oh, slim! ik zal het even proberen.\nAntwoord: ");
                            antwoord = Console.ReadLine();
                            switch (antwoord)
                            {
                                case "1":
                                    Console.Write("Anders moet je het eens aan je medecursisten vragen?\n1. Die weten het antwoord ook niet ...\n2. Ah ja, misschien weten zij het!\nAntwoord: ");
                                    antwoord = Console.ReadLine();
                                    switch (antwoord)
                                    {
                                        case "1":
                                            Console.WriteLine("Probeer het zeker aan je leerkracht te vragen! Die zal zijn best doen om het je uit te leggen");
                                            break;
                                        case "2":
                                            Console.WriteLine("Graag gedaan!"); break;
                                        default: Console.WriteLine("Ongeldig antwoord"); break;
                                    }
                                    break;
                                case "2": Console.WriteLine("Graag gedaan!"); break;
                                default: Console.WriteLine("Ongeldig antwoord"); break;
                            }
                            break;
                        case "2":
                            Console.Write("Oei, wil je iets doen?\n1. Vertel me eens een mopje!\n2. Ik zou graag de oefening afwerken.\n3. Niet per see, tot later!\nAntwoord: ");
                            antwoord = Console.ReadLine();
                            switch (antwoord)
                            {
                                case "1":
                                    Console.WriteLine("Hmm, ik ken er niet meteen eentje, sorry!");
                                    break;
                                case "2":
                                    Console.WriteLine("Ok, dan laat ik je zeker doorwerken!");
                                    break;
                                case "3":
                                    Console.WriteLine("Dag!");
                                    break;
                            }
                            break;
                        case "3": Console.WriteLine("Graag gedaan!"); break;


                        default: Console.WriteLine("Ongeldige input"); break;
                    }

            }
            // wachten
            Console.ReadLine();

        }
    }
}
