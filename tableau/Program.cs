namespace tableau;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
     // Création des deux tableaux de même taille
        int[] tableau1 = { 1, 2, 3, 4, 5 };
        int[] tableau2 = { 6, 7, 8, 9, 10 };

        // Création du troisième tableau avec le double de la taille des deux premiers
        int[] tableau3 = new int[tableau1.Length + tableau2.Length];
        Array.Copy(tableau1, tableau3, tableau1.Length);
        Array.Copy(tableau2, 0, tableau3, tableau1.Length, tableau2.Length);

        // Affichage des tableaux
        Console.WriteLine("Tableau 1:");
        foreach (int element in tableau1)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("Tableau 2:");
        foreach (int element in tableau2)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("Tableau 3:");
        foreach (int element in tableau3)
        {
            Console.WriteLine(element);
        }
    
    }
}
