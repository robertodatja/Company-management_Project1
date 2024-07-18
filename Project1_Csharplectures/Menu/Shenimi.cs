namespace Project1_Csharplectures.Menu
{
    public class Shenimi<T> where T : class
    {
        public Shenimi()
        {
            var tipi = Activator.CreateInstance<T>();
            tipi.KtheID();

            var metodatPublike = tipi.GetType().GetMethods(System.Reflection.BindingFlags.Public);
            var metodaEPare = metodatPublike.OrderBy(m => m.Name).FirstOrDefault();
            Console.WriteLine($"Metoda e pare eshte {metodaEPare?.Name}");

            Console.Write("Metodat tjera jane:");
            for (int i = 0; i < metodatPublike.Length; i++)
            {
                Console.Write($" {metodatPublike[i].Name}");

                var presjeosePike =  (i != metodatPublike.Length - 1) ? "," : ".";

                Console.Write(presjeosePike);
            }
        }
    }
}

