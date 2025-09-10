namespace Sqlite_C_teht_v_;

using Microsoft.Data.Sqlite;
class Program
{
    static void Main(string[] args)
    {
        Taulut taulut = new Taulut();


        while (true)
        {
            Console.WriteLine("Haluatko lisätä henkilön (H), lemmikin (L), näytä puhelinnumero (N) vai lopettaa (X)?");
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

                while (true)
                {
                    Console.WriteLine("haluatko päivittää henkilön puhelin numeron? (K/E)");
                    string? vastaus2 = Console.ReadLine().ToUpper();
                    if (vastaus2 == "K")
                    {
                        Console.WriteLine("Anna henkilön uusi puhelin numero:");
                        int uusiPuhelin = Convert.ToInt32(Console.ReadLine());
                        taulut.PaivitaHenkilonPuhelin(nimi, puhelin, uusiPuhelin);
                        Console.WriteLine("Henkilön puhelin numero päivitetty onnistuneesti!");
                        break;
                    }
                    else if (vastaus2 == "E")
                    {
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
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
            else if (vastaus == "N")
            {
                Console.WriteLine("Anna lemmikin nimi:");
                string? nimi = Console.ReadLine();
                taulut.NaytaPuhelin(nimi);
            }
            else if (vastaus == "X")
            {
                break;
            }
            else
            {
                Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
            }
        }
    }
}
