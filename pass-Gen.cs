using System;

class Program
{
    static Random rnd = new Random();

    static void Main()
    {
        int length = 0;
        int numPassword = 0;

        try
        {
            Console.Write("Longueur du mot de passe : ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Combien de mots de passe générer : ");
            numPassword = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numPassword; i++)
            {
                Console.WriteLine("Mot de passe généré : " + genPass(length));
            }

            Console.Write("Voulez-vous recommencer ? [y / n] : ");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                Main();
            }
        }
        catch
        {
            Console.WriteLine("Erreur lors de l'affichage.");
        }
    }

    static string genPass(int length)
    {
        try
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string password = "";

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                password += chars[index];
            }

            return password;
        }
        catch
        {
            Console.WriteLine("Erreur lors de la génération du mot de passe.");
            return null;
        }
    }
}
