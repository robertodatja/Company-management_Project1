namespace Project1_Csharplectures
{
    public class Detyra
    {
        private int _id;
        public Detyra(int id) => _id = id;
        public string Emertimi => $"DETYRA: {this._id}";
        public int MinutatEPunuara { get; set; }
        public int KohezgjatjaNeMinuta { get; set; } = 5;
        public StatusDetyre Statusi { get; set; } = StatusDetyre.E_LIRE;
    }

    public enum StatusDetyre { E_LIRE, E_NXENE, E_KRYER }
}
