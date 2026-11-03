namespace ParameterTest12E
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Érték szerinti átadás
            Console.WriteLine("1. Normál eset, érték szerinti átadás");
            int a = 5;
            Console.WriteLine($"Hivás előtt az érték: {a}");
            Duplaz(a);
            Console.WriteLine($"A hívás után az {a} érték nem változott");
            Console.WriteLine();
            //2. Referencia szerinti átadás REF
            Console.WriteLine("2. Referencia szerinti átadás");
            int b = 8;
            Console.WriteLine($"Hivás előtt az érték: {b}");
            DuplazRef(ref b);
            Console.WriteLine($"A hívás után az {b} érték nem változott");
            //3. Referencia szerinti átadás OUT 
            Console.WriteLine("3. Referencia OUT szerinti átadás");
            int osszeg;
            int szorzat;
            Szamol(13, 67, out osszeg, out szorzat);

        }

        private static void Szamol(int v1, int v2, out int osszeg, out int szorzat)
        {
            osszeg = v1 + v2;
            szorzat = v1 * v2;
        }

        private static void DuplazRef(ref int szam)
        {
            szam = szam * 2;
            Console.WriteLine($"A metóduson belül a szám értéke: {szam}");
        }

        private static void Duplaz(int szam)
        {
            szam = szam * 2;
            Console.WriteLine($"A metóduson belül a szám értéke: {szam}");
        }
    }
}
