class Program
{
    static void Main()
    {
        // ===== Int tipli CustomList test =====
        CustomList<int> numbers = new CustomList<int>();

        numbers.Add(5000);
        numbers.Add(150);
        numbers.Add(2330);

        Console.WriteLine("Count: " + numbers.Count());

        numbers.Remove(150);
        numbers.Remove(5000);

        Console.WriteLine("Contains 5000? " + numbers.Contains(5000));
        Console.WriteLine("Contains 150? " + numbers.Contains(150));

        numbers.PrintAll();

        numbers.Clear();
        Console.WriteLine("Count after clear: " + numbers.Count());

        Console.WriteLine("-----------");

        // ===== Human tipli CustomList test =====
        try
        {
            Human h1 = new Human("Ali", "Aliyev", 25);
            Human h2 = new Human("Leyla", "Huseynova", 30);

            CustomList<Human> humans = new CustomList<Human>();
            humans.Add(h1);
            humans.Add(h2);

            humans.PrintAll();

            Console.WriteLine("Contains h1? " + humans.Contains(h1));

            humans.Remove(h1);
            humans.PrintAll();

            humans.Clear();
            Console.WriteLine("Count after clear: " + humans.Count());
        }
        catch (AgeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
