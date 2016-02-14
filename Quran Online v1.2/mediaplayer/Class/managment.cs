using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaplayer
{
    class managment
    {
        public static  String serverNumber(String EnglishName)
        {
            String ArabicName = "11";
            if (EnglishName.Equals("shatri"))
                ArabicName = "11";
            else if (EnglishName.Equals("ahmad_huth"))
                ArabicName = "8";
            else if (EnglishName.Equals("hawashi"))
                ArabicName = "11";
            else if (EnglishName.Equals("trabulsi"))
                ArabicName = "10";
            else if (EnglishName.Equals("ajm"))
                ArabicName = "10";
            else if (EnglishName.Equals("trablsi"))
                ArabicName = "10";
            else if (EnglishName.Equals("saud"))
                ArabicName = "11";
            else if (EnglishName.Equals("saber"))
                ArabicName = "8";
            else if (EnglishName.Equals("Aamer"))
                ArabicName = "10";
            else if (EnglishName.Equals("ahmad_nu"))
                ArabicName = "11";
            else if (EnglishName.Equals("akil"))
                ArabicName = "12";
            else if (EnglishName.Equals("akrm"))
                ArabicName = "9";
            else if (EnglishName.Equals("akdr"))
                ArabicName = "6";
            else if (EnglishName.Equals("IbrahemSadan"))
                ArabicName = "10";
            else if (EnglishName.Equals("abkr"))
                ArabicName = "6";
            else if (EnglishName.Equals("jbreen"))
                ArabicName = "6";
            else if (EnglishName.Equals("jormy"))
                ArabicName = "11";
            else if (EnglishName.Equals("ibrahim_dosri_warsh"))
                ArabicName = "10";
            else if (EnglishName.Equals("3siri"))
                ArabicName = "6";
            else if (EnglishName.Equals("zamri"))
                ArabicName = "12";
            else if (EnglishName.Equals("3zazi"))
                ArabicName = "8";
            else if (EnglishName.Equals("dokali"))
                ArabicName = "7";  

            else if (EnglishName.Equals("alzain"))
                ArabicName = "9";
            else if (EnglishName.Equals("omran"))
                ArabicName = "9";
            else if (EnglishName.Equals("koshi"))
                ArabicName = "11";
            else if (EnglishName.Equals("fateh"))
                ArabicName = "6";
            else if (EnglishName.Equals("qari"))
                ArabicName = "11";
            ///new qura
              else if (EnglishName.Equals("twfeeq" ) )ArabicName = "6";
              else if (EnglishName.Equals("jamal"  ) )ArabicName = "6";
              else if (EnglishName.Equals("jaman" ) )ArabicName = "6";
              else if (EnglishName.Equals("hatem"  )   )ArabicName = "11";
              else if (EnglishName.Equals("qht" )   )ArabicName = "10";
              else if (EnglishName.Equals("mohna" ))ArabicName = "11";
              else if (EnglishName.Equals("kafi" )   )ArabicName = "11";
              else if (EnglishName.Equals("tnjy"  ) )ArabicName = "12";
              else if (EnglishName.Equals("hamza" )   )ArabicName = "9";
              else if (EnglishName.Equals("else ifrad" )   )ArabicName = "12";
              else if (EnglishName.Equals("zaki"  )   )ArabicName = "9";
              else if (EnglishName.Equals("sami_dosr")   )ArabicName = "8";
              else if (EnglishName.Equals("s_gmd" )   )ArabicName = "7";
              else if (EnglishName.Equals("shur"  )   )ArabicName = "7";
              else if (EnglishName.Equals("shl"  )   )ArabicName = "6";
              else if (EnglishName.Equals("sayed"  )   )ArabicName = "12";
              else if (EnglishName.Equals("taher" )) ArabicName = "12";
              else if (EnglishName.Equals("hkm" )) ArabicName = "12";
              else if (EnglishName.Equals("sahood"  )) ArabicName = "8";
              else if (EnglishName.Equals("s_bud" )) ArabicName = "6";
              else if (EnglishName.Equals("salah_hashim_m" )) ArabicName = "12";
              else if (EnglishName.Equals("bu_khtr" )) ArabicName = "8";
              else if (EnglishName.Equals("tareq" )) ArabicName = "10";
              else if (EnglishName.Equals("a_klb" )) ArabicName = "8";
              else if (EnglishName.Equals("ryan" )) ArabicName = "8";
              else if (EnglishName.Equals("thubti" )) ArabicName = "6";
              else if (EnglishName.Equals("bari" )) ArabicName = "12";
              else if (EnglishName.Equals("bari_molm" )) ArabicName = "10";
              else if (EnglishName.Equals("basit" )) ArabicName = "7";
              else if (EnglishName.Equals("basit_warsh" )) ArabicName = "10";
              else if (EnglishName.Equals("basit_mjwd" )) ArabicName = "13";
              else if (EnglishName.Equals("sds"  )) ArabicName = "11";
              else if (EnglishName.Equals("soufi_klf" )) ArabicName = "9";
              else if (EnglishName.Equals("soufi" )) ArabicName = "9";
              else if (EnglishName.Equals("a_ahmed" )) ArabicName = "11";
              else if (EnglishName.Equals("brmi" )) ArabicName = "8";
              else if (EnglishName.Equals("Abdullahk" )) ArabicName = "10";
              else if (EnglishName.Equals("mtrod" )) ArabicName = "8";
              else if (EnglishName.Equals("bsfr" )) ArabicName = "6";
              else if (EnglishName.Equals("kyat" )) ArabicName = "12";
              else if (EnglishName.Equals("jhn" )) ArabicName = "13";
              else if (EnglishName.Equals("mohsin_harthi" )) ArabicName = "6";
              else if (EnglishName.Equals("obk" )) ArabicName = "12";
              else if (EnglishName.Equals("qasm" )) ArabicName = "8";
              else if (EnglishName.Equals("kanakeri" )) ArabicName = "6";
              else if (EnglishName.Equals("wdod" )) ArabicName = "8";
              else if (EnglishName.Equals("abo_hashim" )) ArabicName = "9";
              else if (EnglishName.Equals("huthelse ifi_qalon"  )) ArabicName = "9";
              else if (EnglishName.Equals("hthfi"  )) ArabicName = "9";
              else if (EnglishName.Equals("a_jbr" )) ArabicName = "11";
              else if (EnglishName.Equals("hajjaj" )) ArabicName = "9";
              else if (EnglishName.Equals("hafz" )) ArabicName = "6";
              else if (EnglishName.Equals("frs_a"  )) ArabicName = "8";
              else if (EnglishName.Equals("lafi" )) ArabicName = "6";
              else if (EnglishName.Equals("zaml" )) ArabicName = "9";
              else if (EnglishName.Equals("shaibat" )) ArabicName = "9";
              else if (EnglishName.Equals("maher_m" )) ArabicName = "12";
              else if (EnglishName.Equals("maher" )) ArabicName = "12";
              else if (EnglishName.Equals("shaksh" )) ArabicName = "10";
              else if (EnglishName.Equals("ayyub" )) ArabicName = "8";
              else if (EnglishName.Equals("braak" )) ArabicName = "13";
              else if (EnglishName.Equals("tblawi" )) ArabicName = "12";
              else if (EnglishName.Equals("mhsny" )) ArabicName = "11";
              else if (EnglishName.Equals("monshed" )) ArabicName = "10";
              else if (EnglishName.Equals("jbrl" )) ArabicName = "8";
              else if (EnglishName.Equals("rashad" )) ArabicName = "10";
              else if (EnglishName.Equals("shah" )) ArabicName = "12";
              else if (EnglishName.Equals("minsh" )) ArabicName = "10";
              else if (EnglishName.Equals("minsh_mjwd" )) ArabicName = "11";
              else if (EnglishName.Equals("abdullah_dori" )) ArabicName = "12";
              else if (EnglishName.Equals("khan" )) ArabicName = "6";
              else if (EnglishName.Equals("mrelse ifai" )) ArabicName = "11";
              else if (EnglishName.Equals("sheimy" )) ArabicName = "10";
              else if (EnglishName.Equals("husr" )) ArabicName = "13";
              else if (EnglishName.Equals("bna_mjwd" )) ArabicName = "8";
              else if (EnglishName.Equals("afs" )) ArabicName = "8";
              else if (EnglishName.Equals("mustafa" )) ArabicName = "8";
              else if (EnglishName.Equals("lahoni" )) ArabicName = "6";
              else if (EnglishName.Equals("ra3ad" )) ArabicName = "8";
              else if (EnglishName.Equals("harthi" )) ArabicName = "8";
              else if (EnglishName.Equals("muftah_thakwan" )) ArabicName = "11";
              else if (EnglishName.Equals("bilal" )) ArabicName = "11";
              else if (EnglishName.Equals("qtm" )) ArabicName = "6";
              else if (EnglishName.Equals("nabil" )) ArabicName = "9";
              else if (EnglishName.Equals("namh" )) ArabicName = "8";
              else if (EnglishName.Equals("hani" )) ArabicName = "8";
              else if (EnglishName.Equals("waleed" )) ArabicName = "9";
              else if (EnglishName.Equals("yasser" )) ArabicName = "11";
              else if (EnglishName.Equals("qurashi" )) ArabicName = "9";
              else if (EnglishName.Equals("mzroyee" )) ArabicName = "9";
              else if (EnglishName.Equals("yahya" )) ArabicName = "12";
              else if (EnglishName.Equals("yousef" )) ArabicName = "9";
              else if (EnglishName.Equals("noah" )) ArabicName = "8";
            return ArabicName;


        }
        public static ListBeginEndAya autherRanageDetermine(String EnglishName)
        {
            ListBeginEndAya authLengther = new ListBeginEndAya();

            authLengther.beginR = 0;
            authLengther.endread = 114;

              if (EnglishName.Equals("saud"))
            {
                authLengther.beginR = 84;
                authLengther.endread = 114;
            }

            else if (EnglishName.Equals("akil"))
            {
                authLengther.beginR = 49;
                authLengther.endread = 56;
            }

            else if (EnglishName.Equals("IbrahemSadan"))
            {
                authLengther.beginR = 0;
                authLengther.endread = 20;
            }

            else if (EnglishName.Equals("jbreen"))
            {
                authLengther.beginR = 18;
                authLengther.endread = 114;
            }
            else if (EnglishName.Equals("jormy"))
            {
                authLengther.beginR = 39;
                authLengther.endread = 41;
            }

            else if (EnglishName.Equals("3siri"))
            {
                authLengther.beginR = 0;
                authLengther.endread = 75;
            }
            else if (EnglishName.Equals("zamri"))
            {
                authLengther.beginR = 2;
                authLengther.endread = 76;
            }
            else if (EnglishName.Equals("3zazi"))
            {
                authLengther.beginR = 57;
                authLengther.endread = 114;
            }

             else if (EnglishName.Equals("hamza"))
             {
    authLengther.beginR = 1;
                authLengther.endread = 114;

             }
             else if (EnglishName.Equals("sami_dosr"))
             {
                 authLengther.beginR = 28;
                 authLengther.endread = 114;

             }
             else if (EnglishName.Equals("brmi"))
             {
                 authLengther.beginR = 48;
                 authLengther.endread = 114;

             }
             else if (EnglishName.Equals("abo_hashim"))
             {
                 authLengther.beginR = 49;
                 authLengther.endread = 58;

             }
             else if (EnglishName.Equals("lafi"))
             {
                 authLengther.beginR = 29;
                 authLengther.endread = 114;

             }
             else if (EnglishName.Equals("zaml"))
             {
                 authLengther.beginR = 12;
                 authLengther.endread = 114;

             }
             else if (EnglishName.Equals("shaibat"))
             {
                 authLengther.beginR = 77;
                 authLengther.endread = 114;

             }
             else if (EnglishName.Equals("braak"))
             {
                 authLengther.beginR = 49;
                 authLengther.endread = 114;

             }


             else if (EnglishName.Equals("maher_m"))
             {
                 authLengther.beginR = 77;
                 authLengther.endread = 114;

             }
            return authLengther;


        }
    }
}
