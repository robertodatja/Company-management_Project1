/*Kemi nje kompani, e cila ka nje emer; nje menaxher; nje udheheqes qe i udheheq punetoret; ka disa detyra
Menaxheri ose udheheqesi u cakton detyra te ndryshme punetoreve dhe pastaj ato mund te punojne me nje detyre
edhe logohet detyra nese eshte punuar/kryer atehere ndryshon statusi qe dmth u kry.
Gjithashtu Menaxheri ju hedh rrogat.
Etj.*/

namespace Project1_Csharplectures
{
    public static class Kompania
    {
        public static string EmriKompanise = "ABC# Group";
        public static List<Detyra> listaeDetyrave = new List<Detyra>();
        public static List<Punetor> listaePunetoreve = new List<Punetor>();
        public static UdheheqesiGrupit udheheqesi;
        public static Menaxher menaxheri;
    }


    //Interface
    public interface IPunoj { void MerrDetyren(Detyra detyra); void PunoNeDetyren(int idEdetyres, int minuta); }
    public interface IRrogat { void LeshoPagat(); }
    public interface IMenaxhoj { void CaktoDetyren(Detyra detyre, Punetor punetori); }
}
