using System;

namespace Bubblesort
{
    
    class Program
    {
        /// <summary>
        /// Sortieren Sie ein mit Zufallszahlen belegtes Array beliebiger Größe vom Typ int mit dem Bubble-Sort-Verfahren:
        /// Jeweils zwei benachbarte Feldelemente werden vertauscht, wenn sie in der falschen Reihenfolgesind.
        /// Der Vorgang wird wiederholt bis das Array sortiert ist
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Deklaration des Arrays (der Benutzer soll ein Zahl hinschreiben)
            Console.WriteLine("Gib Zahl wie groß soll array sein: "); ;
            int zahl = int.Parse(Console.ReadLine());
            int[] arr = new int[zahl];

            // Erste schleife lässt uns eine Zahlen in die Array eintypen
            Console.WriteLine("Gib nummern in die Array ein: ");
            for (int i = 0; i < arr.Length; i++)
            {
                int n = int.Parse(Console.ReadLine());
                arr[i] = n;
            }

            Console.WriteLine("---------------------------------------");

            int temp; //Wir inizieren eine neue Array. 
                        //Wir brauchen die dafür wir später einzelne werter swapen wollen

            for (int i = 0; i < arr.Length - 1; i++) /*Erstellen wir eine Hauptschleife 
            die da versorgt dass jede einzelne Zahl an ihr Ziel bringt
            Wir erstellen forschleife mit Zahlervariable "i". "-1" weil wir bazieren auf null. 
                Diese schleife wird so oft durchlaufen wie wir in unsere Array an Zahl haben.
                Die sorgt dafur das jedes Element beachtet wird und auf seine entsprechende Position gebracht wird
                Hier wollen wir dafürsorgen dass bei jedem durchlauf einzelnen Zahl nach vorne gebracht werden*/
            {
                for (int j = 0; j < arr.Length - (1 + i); j++) /*Wir erstellen nächste Innereforschleife mit Zahler variable "j".
                 Hier wir vergleichen jede zahl. "+i" es ist weil zB. wenn wir 10 nach vorne gebracht haben und wir beim zweiten durchlauf sind,
                    dann wollen wir bei zweiten durchlauf keine Zahl mit 10 vergleichen. Wissen wir dass 10 ist schon sortiert.
                    Diese "-(1+i)" sorgt dafur dass diese Schleife immer kleiner wird je mehr durchlaufe wie wir in Hauptschleife gemacht haben  */

                {
                    if (arr[j] > arr[j + 1])/*Hier mussen wir vergleichen ob der aktueller 
                                             Zahl grosser ist als die nächste Zahl. */
                    {
                        
                        temp = arr[j + 1];     /*Wenn das so ist, dann wir nutzen umsere vorhe inizierte temp variable.*/
                        arr[j + 1] = arr[j];    //Hier wir bringen Zahl(arr[j]) an die Stelle von arr[j+1] 
                        arr[j] = temp;
                    }
                }
            }

            foreach (int number in arr) {  
                Console.WriteLine(number);
            }

            Console.ReadKey();
                   
        }
    }
}
