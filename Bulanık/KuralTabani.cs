using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulanık
{
    public  class KuralTabani
    {


        //Bulanıklaştırma işlemi yapılıyor kurallara göre 
        public static List<CikisDegeri> Kurallar(GirisDeger gd)
        {
            CikisDegeri cd = new CikisDegeri();

            //üyelik fonksiyonun min degerleri bulmak için gecici dizi
            List<double> temp = new List<double>();

            //kurallara uyan Cikis degerleri için dizi
            List<CikisDegeri> ateslenen = new List<CikisDegeri>();
           
            if(gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru= DonusHiziTuru.hassas;
                cd.DeterjanTuru = DeterjanTuru.cok_az;
                cd.SureTuru = SureTuru.kisa;

                //Üyelik Fonksiyonları kullanıldı aşağıda tekrar
                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik,5.5,8,12.5,14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5, 2, 4));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik,-4.5,-2.5,2,4.5));


                // Durulama işlemi için değerler atandı
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 0.5;
                cd.OrtadakiSure=22.3;
                cd.OrtadakiDeterjan=20;
                ateslenen.Add(cd);
                temp.Clear();


            }
            //2
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.normal_hassas;
                cd.DeterjanTuru = DeterjanTuru.az;
                cd.SureTuru = SureTuru.kisa;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik,5.5,8,12.5,14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5, 2, 4));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik,3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //3
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.normal_kisa;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik,5.5,8,12.5,14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5, 2, 4));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik,5.5,8,12.5,15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;

                ateslenen.Add(cd);
                temp.Clear();
            }

            //4
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru = DonusHiziTuru.hassas;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.kisa;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik,5.5,8,12.5,14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3,5,7));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik,-4.5,-2.5,2,4.5));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;

                ateslenen.Add(cd);
                temp.Clear();
            }
            //5
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.normal_hassas;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.normal_kisa;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik,5.5,8,12.5,14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3,5,7));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //6
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.orta;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik,5.5,8,12.5,14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3,5,7));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik,5.5,8,12.5,15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            //7
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
               cd.DonusTuru= DonusHiziTuru.normal_hassas;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.orta;
                
                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik,5.5,8,12.5,14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5,8,12.5,14));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik,5.5,8,12.5,15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //8
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.normal_hassas;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.orta;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5, 8, 12.5, 14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //9
            if (gd.HassaslikKontrol(HassaslikTuru.hassas) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.normal_uzun;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, 5.5, 8, 12.5, 15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            //10
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru = DonusHiziTuru.normal_hassas;
                cd.DeterjanTuru = DeterjanTuru.az;
                cd.SureTuru = SureTuru.normal_kisa;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik,3,5,7));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4,-1.5,2,4));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, -4.5,-2.5,2,4.5));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
               
                ateslenen.Add(cd);
                temp.Clear();
            }
            //11
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.kisa;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5, 2, 4));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //12
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.normal_guclu;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.orta;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5, 2, 4));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, 5.5,8,12.5,15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            //13
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru = DonusHiziTuru.normal_hassas;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.normal_kisa;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3, 5, 7));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, -4.5, -2.5, 2, 4.5));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //14
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.orta;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3, 5, 7));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //15
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.hassas;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.uzun;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3, 5, 7));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, 5.5,8,12.5,15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            //16
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru = DonusHiziTuru.hassas;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.normal_uzun;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5,8,12.5,14));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, -4, -1.5, 2, 4));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //17
            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.hassas;
                cd.DeterjanTuru = DeterjanTuru.cok_fazla;
                cd.SureTuru = SureTuru.uzun;

                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5, 8, 12.5, 14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3, 5, 7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();

            }
            //18

            if (gd.HassaslikKontrol(HassaslikTuru.orta) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.cok_fazla;
                cd.SureTuru = SureTuru.orta;
                temp.Add(UcgenUyelikFonksiyonu(gd.Hassaslik, 3, 5, 7));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, 5.5, 8, 12.5, 15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            //19
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.az;
                cd.SureTuru = SureTuru.orta;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8,12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5,2, 4));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, -4.5, -2.5, 2, 4.5));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //20
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.normal_guclu;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.orta;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5, 2, 4));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //21
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.kucuk) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.guclu;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.uzun;
                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, -4, -1.5, 2, 4));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, 5.5, 8, 12.5, 15));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            //22
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru = DonusHiziTuru.orta;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.orta;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3,5,7));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, -4.5, -2.5, 2, 4.5));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //23
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.normal_guclu;
                cd.DeterjanTuru = DeterjanTuru.orta;
                cd.SureTuru = SureTuru.normal_uzun;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar, 3,5,7));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //24
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.orta) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.guclu;
                cd.DeterjanTuru = DeterjanTuru.cok_fazla;
                cd.SureTuru = SureTuru.orta;
                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Miktar,3,5,7));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, 5.5, 8, 12.5, 14));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            //25
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.kucuk))
            {
                cd.DonusTuru = DonusHiziTuru.normal_guclu;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.normal_uzun;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, -4.5, -2.5, 2, 4.5));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();

            }
            //26
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.orta))
            {
                cd.DonusTuru = DonusHiziTuru.normal_guclu;
                cd.DeterjanTuru = DeterjanTuru.fazla;
                cd.SureTuru = SureTuru.uzun;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5, 8, 12.5, 14));
                temp.Add(UcgenUyelikFonksiyonu(gd.Kirlilik, 3,5,7));
                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }
            //27
            if (gd.HassaslikKontrol(HassaslikTuru.saglam) && gd.MiktarKontrol(MiktarTuru.buyuk) && gd.KirlilikKontrol(KirlilikTuru.buyuk))
            {
                cd.DonusTuru = DonusHiziTuru.guclu;
                cd.DeterjanTuru = DeterjanTuru.cok_fazla;
                cd.SureTuru = SureTuru.uzun;

                temp.Add(YamukUyelikFonksiyonu(gd.Hassaslik, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Miktar, 5.5, 8, 12.5, 14));
                temp.Add(YamukUyelikFonksiyonu(gd.Kirlilik, 5.5,8,12.5,15));

                cd.AteslenenDeger = temp.Min();
                cd.OrtadakiDonus = 2.75;
                cd.OrtadakiSure = 85;
                cd.OrtadakiDeterjan = 20;
                ateslenen.Add(cd);
                temp.Clear();
            }

            return ateslenen;
        }



       //Durulama işlemi ağırlıklı ortalama göre yapan fonksiyon 
        public static double AgirlikliOrtalama(List<CikisDegeri> list)
        {
            double pay = 0, payda = 0;

            foreach (var item in list)
            {
                pay += item.AteslenenDeger * item.OrtadakiDonus;
                payda += item.AteslenenDeger;
            }

            return pay / payda;
 
        }


        //üyelik fonksiyonları
        static double UcgenUyelikFonksiyonu(double x, double a, double b, double c)
        {
            if (x < a)
            {
                return 0;
            }
            else if (x >= a && x <= b)
            {
                return ((x - a) / (b - a));
            }
            else if (x >= b && x <= c)
            {
                return ((c - x) / (c - b));
            }
            else if (x > c)
            {
                return 0;
            }

            return 0;
        }

        //üyelik fonksiyonları
       static double YamukUyelikFonksiyonu(double x, double a, double b, double c, double d)
        {
            if (x < a)
            {
                return 0;
            }
            else if (x >= a && x <= b)
            {
                return ((x - a) / (b - a));
            }
            else if (x >= b && x <= c)
            {
                return 1;
            }
            else if (x >= c && x <= d)
            {
                return ((d - x) / (d - c));
            }
            else if (x > d)
            {
                return 0;
            }

            return 0;
        }
    }

}
