namespace Sqlite_C_teht_v_;

using Microsoft.Data.Sqlite;
class Program
{
    static void Main(string[] args)
    {
        Taulut taulut = new Taulut();


        while (true)
        {
            Console.WriteLine("Haluatko lisätä henkilön (H), lemmikin (L), päivittää puhelinnumeron (P), näytä puhelinnumero (N) vai lopettaa (X)?");
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
                int omistajaNimi = Convert.ToInt32(Console.ReadLine());

                taulut.LisaaLemmikki(nimi, rotu, omistajaNimi);

                Console.WriteLine("Lemmikki lisätty onnistuneesti!");

            }
            else if (vastaus == "P")
            {
                Console.WriteLine("Anna henkilön nimi:");
                string? nimi = Console.ReadLine();
                Console.WriteLine("Anna henkilön uusi puhelinnumero:");
                int uusiPuhelin = Convert.ToInt32(Console.ReadLine());

                taulut.PaivitaHenkilonPuhelin(nimi, uusiPuhelin);
                Console.WriteLine("Henkilön puhelinnumero päivitetty onnistuneesti!");
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
