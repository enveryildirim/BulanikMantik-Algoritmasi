using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bulanık
{
    public class CikisDegeri
    {
        //
        public double DonusHizi { get; set; }
        public double Sure { get; set; }
        public double Deterjan { get; set; }

        //kural tabanında kullanılacak degerler
        public DonusHiziTuru DonusTuru { get; set; }
        public SureTuru SureTuru { get; set; }
        public DeterjanTuru DeterjanTuru { get; set; }

        //durulama işlemi yani ağırlıklı ortalama için kullanılacak değerler
        public double AteslenenDeger { get; set; }
        public double OrtadakiDonus { get; set; }
        public double OrtadakiSure { get; set; }
        public double OrtadakiDeterjan { get; set; }


        //kural tabanında kullanılacak
        public bool DonusHiziKontrol(DonusHiziTuru dt)
        {
            bool tmp=false;
                if (DonusHizi < 2 && DonusHiziTuru.hassas==dt)
                    tmp=true;
                else if((DonusHizi<4 && DonusHizi>1)&& DonusHiziTuru.normal_hassas==dt)
                    tmp=true;
                else if((DonusHizi<7 && DonusHizi>5)&& DonusHiziTuru.orta==dt)
                    tmp=true;
                else if((DonusHizi<9 && DonusHizi>8)&& DonusHiziTuru.normal_guclu==dt)
                    tmp=true;
                else if(( DonusHizi>8 && DonusHizi<=10) && DonusHiziTuru.guclu==dt)
                    tmp=true;

                return tmp; 
            
 
        }

       
        public bool SureKontrol(SureTuru st)
        {
             bool tmp=false;
                if (Sure < 20 && SureTuru.kisa==st)
                    tmp=true;
                else if((Sure<40 && Sure>10)&& SureTuru.normal_kisa==st)
                    tmp=true;
                else if((Sure<70 && Sure>50)&& SureTuru.orta==st)
                    tmp=true;
                else if((Sure<90 && Sure>80)&& SureTuru.normal_uzun==st)
                    tmp=true;
                else if((Sure>85 &&Sure<=100) && SureTuru.uzun==st)
                    tmp=true;

                return tmp; 

        }

        public bool DeterjanKontrol(DeterjanTuru dt)
        {
           bool tmp=false;
                if (Deterjan < 40 && DeterjanTuru.az==dt)
                    tmp=true;
                else if((Deterjan<80 && Deterjan>100)&& DeterjanTuru.cok_az==dt)
                    tmp=true;
                else if((Deterjan<90 && Deterjan>150)&& DeterjanTuru.orta==dt)
                    tmp=true;
                else if((Deterjan<200 && Deterjan>130)&& DeterjanTuru.fazla==dt)
                    tmp=true;
                else if((Deterjan<300 && Deterjan>190) && DeterjanTuru.cok_fazla==dt)
                    tmp=true;

                return tmp; 

        }
        
    }
    public enum DonusHiziTuru {guclu,normal_guclu,orta,normal_hassas,hassas}

    public enum SureTuru {uzun,normal_uzun,orta,normal_kisa,kisa}

    public enum DeterjanTuru {cok_fazla,fazla,orta,az,cok_az}
    
}
