namespace Project1_Csharplectures
{
    public abstract class Person
    {
        public string Emri { get; set; }
        public int Mosha { get; set; }
        public virtual void Flet() => Console.WriteLine($"Personi {Emri} po flet.");
        public void ShenoID() => this.KtheID();
    }

    public static class Identitet
    {
        public static void KtheID(this object personi)
        {
            var njeriu = personi as Person;
            var tipi = personi?.GetType().ToString();
            Console.WriteLine($"Profesioni i {njeriu?.Emri} qe ka moshen {njeriu?.Mosha}, eshte {tipi}.");
        }
    }


}
