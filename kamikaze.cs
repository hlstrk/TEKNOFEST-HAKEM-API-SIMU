namespace HAKEM.API.V2
{
    public class kamikazeBaslangicZamani
    {
        public int saat { get; set; }
        public int dakika { get; set; }
        public int saniye { get; set; }
        public int milisaniye { get; set; }
    }

    public class kamikazeBitisZamani
    {
        public int saat { get; set; }
        public int dakika { get; set; }
        public int saniye { get; set; }
        public int milisaniye { get; set; }
    }



    public class kamikaze
    {
   
        public kamikazeBaslangicZamani? kamikazeBaslangicZamani { get; set; }
        public kamikazeBitisZamani? kamikazeBitisZamani { get; set; }

        public string qrMetni { get; set; }
        

    }

}
