using Iks_Dmitry_CatFramework;

namespace Iks_Dmitry_CatApplication
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cats to generate: ");
            var catCount = uint.Parse(Console.ReadLine());

            Cat[] cats = GenerateRandomCats(catCount);

            Console.Write("Enter the path to save the output file: ");
            string path = Console.ReadLine();

            DisplayCatInfo(cats, path);
        }

        static Cat[] GenerateRandomCats(uint count)
        {
            var random = new Random();
            var cats = new Cat[count];

            for (int i = 0; i < count; i++)
            {
                bool success = false;
                while (!success)
                {
                    try
                    {
                        if (random.Next(2) == 0)
                        {
                            cats[i] = new Tiger<int, int>(random.Next(50, 161), random.Next(-20, 121));
                        }
                        else
                        {
                            cats[i] = new CuteCat<float>(random.Next(-20, 121));
                        }
                        success = true;
                    }
                    catch (CatException ex)
                    {
                        Console.WriteLine($"Exception: {ex.Message}");
                    }
                }
            }

            return cats;
        }

        static void DisplayCatInfo(Cat[] catsArr, string path)
        {
            using var file = new StreamWriter(path, false);

            foreach (var cat in catsArr)
            {
                string info = $"{cat.FluffinessCheck()} - {cat.ToString()}";
                Console.WriteLine(info);
                file.WriteLine(info);
            }
        }
    }
}