namespace Project1_Csharplectures
{
    public class Punetor : Person, IPunoj
    {
        private List<Detyra> _detyrat = new List<Detyra>();
        public IEnumerable<Detyra> DetyratEPakryera()
        {
            return _detyrat.Except(DetyratEkryera());
        }

        public event EventHandler<string> DetyraKryer;

        public IEnumerable<Detyra> DetyratEkryera()
        {
            return _detyrat.Where(d => d.Statusi == StatusDetyre.E_KRYER);
        }

        public void MerrDetyren(Detyra detyra) => this._detyrat.Add(detyra);

        public void PunoNeDetyren(int idEdetyres, int minutat)
        {
            var detyra = this._detyrat.FirstOrDefault(d => d.Emertimi == $"DETYRA: {idEdetyres}");

            if (detyra == null)
                Console.WriteLine($"Detyra me id {idEdetyres} nuk eshte ne listen e detyrave te punetorit {this.Emri}.");
            else
            {
                Console.WriteLine($"Punetori {this.Emri} po punon ne {detyra.Emertimi} per {minutat} minuta.");
                detyra.MinutatEPunuara += minutat;
                if (detyra.KohezgjatjaNeMinuta <= detyra.MinutatEPunuara)
                {
                    detyra.Statusi = StatusDetyre.E_KRYER;
                    Console.WriteLine($"Punetori {this.Emri} e kryti me sukses detyren {detyra.Emertimi}.");
                    DetyraKryer?.Invoke(detyra, this.Emri);
                }
            }
        }
    }

}
