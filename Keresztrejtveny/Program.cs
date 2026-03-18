namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeresztrejtvenyRacs r1 = new KeresztrejtvenyRacs("kr1.txt");

			Console.WriteLine("Az 5. feladat:");
			Console.WriteLine($"\tSorok száma: {r1.SorokSzama}");
			Console.WriteLine($"\tOszlopok száma: {r1.OszlopokSzama}");

			Console.WriteLine("6. feladat:");
            r1.KiirRacs();

			Console.WriteLine("7. feladat");
			Console.WriteLine($"A leghosszabb szó hossza: {r1.LeghosszabbSzo}");
		}
    }
}
