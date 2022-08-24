namespace HAKEM.API.V2
{
    public class KilitlenmeBaslangicZamani
    {
        public int saat { get; set; }
        public int dakika { get; set; }
        public int saniye { get; set; }
        public int milisaniye { get; set; }
    }

    public class KilitlenmeBitisZamani
    {
        public int saat { get; set; }
        public int dakika { get; set; }
        public int saniye { get; set; }
        public int milisaniye { get; set; }
    }

    public class Kilitlenme
    {
        public KilitlenmeBaslangicZamani? kilitlenmeBaslangicZamani { get; set; }
        public KilitlenmeBitisZamani? kilitlenmeBitisZamani { get; set; }
        public bool otonom_kilitlenme { get; set; }
    }
}
