class Program
{
    // Créez des fonctions et documentez les.


    static void Main(string[] args)
    {
        // Point d'entrée du programme


        //Hauteur de la fenêtre console en nombre de lignes
        int consoleHeight = Console.WindowHeight;
        int consoleWidth = Console.WindowWidth;


        // list de poulet
        List<string> chicken_list = new List<string>();
        
        chicken_list.Add("🐔");
        chicken_list.Add("🐔");
        chicken_list.Add("🐔");
        //chicken_list.Add("🐔");
        //chicken_list.Add("🐔");
        //chicken_list.Add("🐔");
        //chicken_list.Add("🐔");
        //chicken_list.Add("🐔");
        //chicken_list.Add("🐔");
        //chicken_list.Add("🐔");
        //chicken_list.Add("🐔"); 

        List<int> list_chiffre = new List<int>();
        string le_poulet = "";


        int sol = consoleHeight - 2;
        int width = consoleWidth - 2;

       
        int x = 0; int y = 0; int counter = 0;


        while (true)
        {

            for (int i = 0; i < chicken_list.Count; i++)
            {

                if (counter == i)
                {
                    le_poulet = chicken_list[i];
                    break;
                }

            }
            while (y != sol)
            {
                Console.SetCursorPosition(x, y);


                //Positionner le curseur sur une position spécifique dans la console:
                //x = la colonne(de gauche à droite, commence à 0).
                //y = la ligne(de haut en bas, commence à 0).


                // Configuration pour afficher les emojis
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine(le_poulet);
                Console.WriteLine(le_poulet);


                Thread.Sleep(40);
               
                y++;

                // Effacer la console 

                Console.Clear()
;            }
            Random random = new Random(); // Une seule instance de Random pour éviter les répétitions
            int posMin = 10; int posMax = 118;
            int le_number = random.Next(posMin, posMax + 1);

            y = 0;
            counter++;
            x = le_number;

        }





        
    }
}