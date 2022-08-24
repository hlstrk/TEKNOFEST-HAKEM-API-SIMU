namespace HAKEM.API.V2
{
    public class rondomtelemolustur
    {

        public static List<telemcvptakimlar> telemal()
        {
            List<telemcvptakimlar> liste = new List<telemcvptakimlar>();

            Random rnd = new Random();

            





            
            for (int i = 0;i<4;i++)
            {
                
                liste.Add(singletelemolustur());


            }



            return liste;
        }


        public static telemcvptakimlar singletelemolustur()
        {
            telemcvptakimlar veri = new telemcvptakimlar();

            Random rnd = new Random();


            veri.takim_numarasi = rnd.Next(0, 3);
            veri.iha_enlem = rnd.Next(40, 42);
            veri.iha_boylam = rnd.Next(30, 32);
            veri.iha_irtifa = rnd.Next(1, 500);
            veri.iha_dikilme = rnd.Next(1, 100);
            veri.iha_yonelme = rnd.Next(1, 40);
            veri.iha_yatis = rnd.Next(1, 100);
            veri.zaman_farki = rnd.Next(1, 100);



            return veri;
        }






    }
}


