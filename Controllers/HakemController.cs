using HAKEM.API.V2;
using Microsoft.AspNetCore.Mvc;

namespace Telemetri.API.Controllers
{


    [ApiController]
    [Route("api/[action]")]
    public class HakemController : ControllerBase
    {
       

        public static string? yetkivarmi;
        public static int puan;
        public static int qrpuan;

        public GPSSaati sistemzaman = new GPSSaati();
        public konumbilgileri takimbilgileri = new konumbilgileri();

        public tumbilgiler traceveri = new tumbilgiler();






        public HakemController()
        {



        }











        [HttpGet]
        public async Task<IActionResult> sunucusaati()
        {


            if (yetkivarmi == "var")
            {


                var time = DateTime.Now;

                GPSSaati sunucutime=new GPSSaati();


                sunucutime.saat = time.Hour;

                sunucutime.dakika = time.Minute;

                sunucutime.saniye = time.Second;

                sunucutime.milisaniye = time.Millisecond;
                return Ok(sunucutime);

            }


            else
            {
                return Unauthorized();

            }






        }


        [HttpGet]
        public async Task<IActionResult> qr_koordinati()
        {


            if (yetkivarmi == "var")
            {


         

                qrkoordinat koordinat = new qrkoordinat();


                koordinat.qrEnlem = 41.123456;

                koordinat.qrBoylam = 26.654987;

              
                return Ok(koordinat);

            }


            else
            {
                return Unauthorized();

            }






        }




        [HttpPost]
        public async Task<IActionResult> telemetri_gonder([FromBody] tumbilgiler _telemetriler)
        {


            if (yetkivarmi == "var")
            {
                if (_telemetriler == null)
                {
                    return BadRequest();
                }


                if (_telemetriler == null)
                {
                    return NotFound();
                }

                Random rnd = new Random();


                KonumBilgileri telemcevap = new KonumBilgileri();
               


               






                GPSSaati sistemzaman = new GPSSaati();


                var time = DateTime.Now;




                sistemzaman.saat = time.Hour;

                sistemzaman.dakika = time.Minute;

                sistemzaman.saniye = time.Second;

                sistemzaman.milisaniye = time.Millisecond;

                telemcevap.sistemSaati = sistemzaman;





                telemcevap.konumBilgileri = rondomtelemolustur.telemal();






















                return Ok(telemcevap);

            }

            else
            {
                return Unauthorized();

            }

        }


        [HttpPost]
        public async Task<IActionResult> giris([FromBody] giris _girisverileri)
        {




            if (_girisverileri != null)
            {

                if (_girisverileri.kadi == "abraiha" & _girisverileri.sifre == "123456")
                {
                    yetkivarmi = "var";
                    Random rnd = new Random();


                    int takimnumarasi = rnd.Next(1, 99);


                    var numara = new takimnumara();
                    numara.takim_numarasi = takimnumarasi;
                    return Ok(numara);

                }
                else
                {
                    yetkivarmi = "yok";
                    return BadRequest();

                }
            }

            else
            {
                return NotFound();
            }
















        }

        [HttpPost]
        public async Task<IActionResult> kamikaze_bilgisi([FromBody] kamikaze _kamikaze)
        {


            if (yetkivarmi == "var")
            {
                if (_kamikaze == null)
                {
                    return BadRequest();
                }


                if (_kamikaze == null)
                {
                    return NotFound();
                }





                if (_kamikaze != null)
                {
                    if(_kamikaze.qrMetni!="teknofest2022")
                    {
                        return Unauthorized("Gönderilen QR kodu hatalı!");
                    }

                    else
                    {
                        qrpuan = qrpuan + 1;
                    }
                }



































                return Ok();

            }

            else
            {
                return Unauthorized();

            }

        }




        [HttpPost]
        public async Task<IActionResult> puan_sorgula()
        {




            var numara = new puan();
            numara.iha_puan = puan;



            return Ok(numara);
















        }

        [HttpPost]
        public async Task<IActionResult> kamikaze_puan_sorgula()
        {




            var numara = new puan();
            numara.iha_puan = qrpuan;



            return Ok(numara);
















        }

        [HttpPost]
        public async Task<IActionResult> puan_sifirla()
        {





            puan = 0;
           

            return Ok();
















        }


        [HttpPost]
        public async Task<IActionResult> cikis()
        {






            yetkivarmi = "yok";

            return Ok();
















        }


        [HttpPost]
        public async Task<IActionResult> kilitlenme_bilgisi([FromBody] Kilitlenme _kilitlenme)
        {


            if (yetkivarmi == "var")
            {
                if (_kilitlenme == null)
                {
                    return BadRequest();
                }









                puan = puan + 1;











                return Ok(_kilitlenme);
            }

            else
            {
                return Unauthorized();
            }

        }






    }
}