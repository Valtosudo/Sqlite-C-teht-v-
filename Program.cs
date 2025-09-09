namespace Sqlite_C_teht_v_;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hei! Haluatko lisätä henkilön (H) vai lemmikin (L)?");

        while (true)
        {
            string? input = Console.ReadLine();
            string vastaus = input.ToUpper();

            if (vastaus == "H")
            {
                break;
            }
            else if (vastaus == "L")
            {
                break;
            }
            else
            {
                Console.WriteLine("Väärä syöte. Yritä uudelleen.");
            }
        }
    }
}
