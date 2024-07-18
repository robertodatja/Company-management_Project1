namespace Project1_Csharplectures.Menu
{
    public class MenyjaMenaxherit
    {
        public MenyjaMenaxherit()
        {
            while (true)
            {
                Console.WriteLine("Menyja e menaxherit:");
                Console.WriteLine("1. Mbane mledhje");
                Console.WriteLine("2. Leshon pagat");
                Console.WriteLine("3. Cakton detyren");
                Console.WriteLine("4. Kthehu mbrapa");

                var hyrje = int.Parse(Console.ReadLine());
                switch (hyrje)
                {
                    case 1:
                        Kompania.menaxheri.Flet(); break;

                    case 2:
                        Kompania.menaxheri.LeshoPagat(); break;

                    case 3: 
                        Console.WriteLine("cakton detyren..."); break;

                    default: 
                        return;
                }
            }
        }

    }
}
