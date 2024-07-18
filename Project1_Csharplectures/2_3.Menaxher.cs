namespace Project1_Csharplectures
{
    public class Menaxher : Person, IMenaxhoj, IRrogat
    {
        private readonly OperacioneMenaxhimi _operacioneMenaxhimi;
        public List<Punetor> Punetoret { get; set; }

        public Menaxher(OperacioneMenaxhimi operacioneMenaxhimi, List<Punetor> punetoret)
        {
            _operacioneMenaxhimi = operacioneMenaxhimi;
            Punetoret = punetoret;

            foreach (var item in Punetoret)
            {
                item.DetyraKryer += Item_DetyraKryer;
            }
        }

        private void Item_DetyraKryer(object? sender, string emri)
        {
            var detyre = sender as Detyra;
            Console.WriteLine($"O shef, {detyre.Emertimi} u krye me sukses nga {emri}.");
        }

        public void CaktoDetyren(Detyra detyre, Punetor punetori)
        {
            detyre.Statusi = StatusDetyre.E_NXENE;
            punetori.MerrDetyren(detyre);
        }

        public override void Flet()
        {
            Console.WriteLine($"Menaxheri {Emri} po mbane mbledhje.");
        }

        public void LeshoPagat()
        {
            _operacioneMenaxhimi.PaguajPunetoret(Punetoret);
        }

    }


    public class OperacioneMenaxhimi
    {
        public void PaguajPunetoret(List<Punetor> punetoret)
        {
            Console.WriteLine("Pagat u leshuan per punetoret: ");
            foreach (var p in punetoret) { Console.WriteLine(p.Emri); }
        }
    }

}
