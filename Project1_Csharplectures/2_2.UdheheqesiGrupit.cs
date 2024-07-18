namespace Project1_Csharplectures
{
    public class UdheheqesiGrupit : Punetor, IMenaxhoj
    {
        public List<Punetor> Punetoret { get; set; }

        public UdheheqesiGrupit(List<Punetor> punetoret)
        {
            Punetoret = punetoret;
            if (Punetoret.Any(p => p == this))
            {
                Punetoret.Remove(this);
            }

            foreach (var item in Punetoret)
            {
                item.DetyraKryer += Item_DetyraKryer;
            }
        }

        private void Item_DetyraKryer(object? sender, string emri)
        {
            var detyre = sender as Detyra;
            Console.WriteLine($"{detyre.Emertimi} u krye me sukses nga {emri}.");
        }


        public void CaktoDetyren(Detyra detyre, Punetor punetori)
        {
            if (Punetoret.Any(p => p == punetori))
            {
                detyre.Statusi = StatusDetyre.E_NXENE;
                punetori.MerrDetyren(detyre);
            }
            else
                Console.WriteLine("Udheheqesi i grupit nuk mund ti caktoje detyre vetes.");
        }

        public override void Flet()
        {
            base.Flet();
            Console.WriteLine("Si udheheqes grupi.");
        }
    }
}
