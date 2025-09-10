namespace Sqlite_C_teht_v_;

using Microsoft.Data.Sqlite;
class Program
{
    static void Main(string[] args)
    {
        Taulut taulut = new Taulut();


        while (true)
        {
            Console.WriteLine("Haluatko lisätä henkilön (H) vai lemmikin (L) Vai lopettaa (X)?");
            string? input = Console.ReadLine();
            string vastaus = input.ToUpper();

            if (vastaus == "H")
            {
                Console.WriteLine("Anna henkilön nimi:");
                string? nimi = Console.ReadLine();
                Console.WriteLine("Anna henkilön puhelin:");
                int puhelin = Convert.ToInt32(Console.ReadLine());

                taulut.LisaaHenkilo(nimi, puhelin);

                Console.WriteLine("Henkilö lisätty onnistuneesti!");
            }
            else if (vastaus == "L")
            {
                Console.WriteLine("Anna lemmikin nimi:");
                string? nimi = Console.ReadLine();
                Console.WriteLine("Anna lemmikin rotu:");
                string? rotu = Console.ReadLine();
                Console.WriteLine("Anna omistajan ID:");
                int omistajaID = Convert.ToInt32(Console.ReadLine());

                taulut.LisaaLemmikki(nimi, rotu, omistajaID);

                Console.WriteLine("Lemmikki lisätty onnistuneesti!");

            }
            else if (vastaus == "X")
            {
                Console.WriteLine("Heippa 😊");
                break;
            }
            else
            {
                Console.WriteLine("Väärä syöte. Yritä uudelleen.");
            }
        }
    }
}
