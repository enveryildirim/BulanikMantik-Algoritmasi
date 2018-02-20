using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulanık
{
    public class GirisDeger
    {
        public double Hassaslik { get; set; }
        public double Miktar { get; set; }
        public double Kirlilik { get; set; }

       //kural tabanında kullanılkacak 
        public bool HassaslikKontrol(HassaslikTuru ht)
        {
            bool tmp=false;
                if ((Hassaslik>0 && Hassaslik < 4) && HassaslikTuru.hassas==ht)
                    tmp=true;
                else if((Hassaslik<6 && Hassaslik>3)&& HassaslikTuru.orta==ht)
                    tmp=true;
                else if((Hassaslik<10 && Hassaslik>5) && HassaslikTuru.saglam==ht)
                    tmp=true;

                return tmp; 
            
 
        }

       
        public bool MiktarKontrol(MiktarTuru mt)
        {
            bool tmp = false;
            if ((Miktar>0 && Miktar < 4) && MiktarTuru.kucuk == mt)
                tmp = true;
            else if ((Miktar < 6 && Miktar > 3) && MiktarTuru.orta==mt)
                tmp = true;
            else if ((Miktar<10 && Miktar > 5) && MiktarTuru.buyuk==mt)
                tmp = true;

           return tmp;
            

        }

        public bool KirlilikKontrol(KirlilikTuru kt)
        {
           bool tmp = false;
           if ((Kirlilik>0 && Kirlilik < 4) && KirlilikTuru.kucuk == kt)
                tmp = true;
           else if ((Kirlilik < 6 && Kirlilik > 3) && KirlilikTuru.orta == kt)
                tmp = true;
           else if ((Kirlilik<10 && Kirlilik > 5) && KirlilikTuru.buyuk == kt)
                tmp = true;

           return tmp;

        }
        
    }

    //
    public enum HassaslikTuru {saglam,orta,hassas}
    public enum MiktarTuru { buyuk, orta, kucuk }
    public enum KirlilikTuru { buyuk, orta, kucuk }
    
}

