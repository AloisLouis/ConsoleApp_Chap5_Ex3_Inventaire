using System;

namespace ConsoleApp_Chap5_Ex3_Inventaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez le nombre d'objets que vous souhaitez stocker dans votre sac!");
            int objets = int.Parse(Console.ReadLine());
            double p = 0;
            double lourds = 0;
            double legers = 0;

            for (int i = 0; i < objets; i++)
            {
                Console.WriteLine("Saisissez le poids de l'objet!");
                double poids = double.Parse(Console.ReadLine());
                p += poids;
                if (poids > 5)
                {
                    lourds ++;
                }
                else
                {
                    legers ++;
                }
            }

            if (p > 30)
            {
                Console.WriteLine("[SURCHARGE] Votre sac est trop lourd, vous ne pouvez pas courir!");
            }
            else
            {
                Console.WriteLine("[OK] Votre inventaire est prêt pour l'aventure!");
            }
            Console.WriteLine("Il y a {0} objets lourds et {1} objets légers.", lourds, legers);
        }
    }
}