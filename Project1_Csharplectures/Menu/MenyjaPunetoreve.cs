namespace Project1_Csharplectures.Menu
{
    public class MenyjaPunetoreve
    {
        public MenyjaPunetoreve()
        {
            while (true)
            {
                Console.WriteLine("Menyja e punetoreve.");
                Console.WriteLine("Zgjidh punetorin: ");

                for (int i = 0; i < Kompania.listaePunetoreve.Count; i++)
                {
                    Console.WriteLine($"{i} {Kompania.listaePunetoreve[i].Emri}");
                }

                var index = int.Parse(Console.ReadLine());

                if (index < 0 || index > Kompania.listaePunetoreve.Count-1)
                    return;

                var puntori = Kompania.listaePunetoreve[index];

                Console.WriteLine($"Zgjodhet punteorin {puntori.Emri}");

                break;
            }
        }
    }
}
