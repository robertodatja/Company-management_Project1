namespace Project1_Csharplectures.Menu
{
    public class InfoKompania
    {
        public InfoKompania()
        {

            Console.WriteLine("KOMPANIA:" + Kompania.EmriKompanise);


            Console.WriteLine("Menaxheri i Kompanise eshte:");
            var menaxher = Kompania.menaxheri;
            Console.WriteLine($"{menaxher.Emri} dhe eshte vetem {menaxher.Mosha} vjec.");


            Console.WriteLine("Punetoret e Kompanise jane:");
            foreach (var p in Kompania.menaxheri.Punetoret)
            {
                Console.WriteLine($"{p.Emri} | {p.Mosha} vjec.");
            }


            var detyratEkryera = Kompania.listaeDetyrave.Where(d => d.Statusi == StatusDetyre.E_KRYER);
            if(detyratEkryera.Any()) 
            { 
                Console.WriteLine("Kompania ka kryer me sukses keto detyra:");
                foreach (var d in detyratEkryera)
                {
                    Console.Write($"{d.Emertimi} ");
                }
            }
        }

    }
}
