namespace HAKEM.API.V2
{
    public class tumbilgiler
    {

        public int takim_numarasi { get; set; }
        public float IHA_enlem { get; set; }
        public float IHA_boylam { get; set; }
        public float IHA_irtifa { get; set; }
        public float IHA_dikilme { get; set; }
        public float IHA_yonelme { get; set; }
        public float IHA_yatis { get; set; }
        public float IHA_hiz { get; set; }
        public int IHA_batarya { get; set; }
        public bool? IHA_otonom { get; set; }
        public bool? IHA_kilitlenme { get; set; }
        public int Hedef_merkez_X { get; set; }
        public int Hedef_merkez_Y { get; set; }
        public int Hedef_genislik { get; set; }
        public int Hedef_yukseklik { get; set; }
        public GPSSaati? GPSSaati { get; set; }
    }
}
