namespace Project1_Csharplectures.Menu
{
    public class Programi
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mire se vini ne programin tone.");
            //1
            Console.WriteLine("Tregoni numrin e detyrave qe doni ti krijoni?");
            var ndetyrave = int.Parse(Console.ReadLine());
            for (int i = 1; i <= ndetyrave; i++) { Kompania.listaeDetyrave.Add(new Detyra(i)); }

            //2_1
            Console.WriteLine("Specifikoni punetoret ne formatin emri#mosha,emri#mosha:");
            var punetoretString = Console.ReadLine(); //Arjan#34,Arben#25
            var lpunetoreve = punetoretString.Split(','); //string[] lp = {"Arjan#34", "Arben#25" }
            foreach (var p in lpunetoreve)
            {
                var punetori = p.Split('#');
                Kompania.listaePunetoreve.Add(new Punetor() { Emri = punetori[0], Mosha = int.Parse(punetori[1]) });
            }

            //2_2
            Console.WriteLine("Specifikoni udheheqesin ne formatin emri#mosha?");
            var udheheqesiString = Console.ReadLine(); //Arjan#34,Arben#25,Burim#20,Afrim#40
            var infoUdheheqesi = udheheqesiString.Split('#');
            Kompania.udheheqesi = new UdheheqesiGrupit(Kompania.listaePunetoreve) { Emri = infoUdheheqesi[0], Mosha = int.Parse(infoUdheheqesi[1]) };

            //2_3
            var punetoretEMenaxherit = Kompania.listaePunetoreve.Select(x => x).ToList();
            punetoretEMenaxherit.Add(Kompania.udheheqesi);
            //
            Console.WriteLine("Specifikoni Menaxherin ne formatin emri#mosha?");
            var menaxheriString = Console.ReadLine(); //Arjan#34,Arben#25,Burim#20,Afrim#40
            var infoMenaxheri = menaxheriString.Split('#'); //{ Arjan, 34}
            Kompania.menaxheri = new Menaxher(new OperacioneMenaxhimi(), punetoretEMenaxherit) { Emri = infoMenaxheri[0], Mosha = int.Parse(infoMenaxheri[1]) };


            //-------------------------------------------------
            while (true)
            {
                Console.WriteLine("Zgjidh njeren:");
                Console.WriteLine("1. Menyne per Punetoret");
                Console.WriteLine("2. Menyne per Udheheqesin");
                Console.WriteLine("3. Menyne per Menaxherin");
                Console.WriteLine("4. Info per Kompanine");

                var hyrje = int.Parse(Console.ReadLine());
                switch (hyrje)
                {
                    case 1: 
                        new MenyjaPunetoreve(); break;

                    case 2: 
                        new MenyjaUdheheqesit(); break;

                    case 3: 
                        new MenyjaMenaxherit(); break;

                    case 4: 
                        new InfoKompania(); break;

                    default: 
                        new Shenimi<Punetor>(); break;
                }
            }

        }


    }

}
