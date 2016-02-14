using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace mediaplayer
{
    class LnaguageClass
    { /// for arabic=1 for english=2
        public static int LanguageSelect;
        public static List<string> ServerFolderName = new List<string>();
        public static ObservableCollection<AuthorClass> AutherListInfo = new ObservableCollection<AuthorClass>();
        private static ObservableCollection<AuthorClass> ListAya = new ObservableCollection<AuthorClass>();
        public static ObservableCollection<AuthorClass> ListAyaRanage = new ObservableCollection<AuthorClass>();
        public static int ISBackgroundMusic = 1; // 1 for is not, 20 for out back ground 3 for in background
        public static bool  Firstentry  = true;
        // for public folder select 
        public static string OtherFolderName;
        public static int ServerNumber = 1;
      //=============================
        // lablename ca-app-pub-7315471620590850/6141964124
        public static string AuthorNmae()
        {
            if (LanguageSelect == 1)

                return ("اسماء القراء");

            else
                return ("Author Name");


        }

        public static string playv()
        {
            if (LanguageSelect == 1)

                return ("تشغيل");

            else
                return ("Play");


        }

        public static string pausev()
        {
            if (LanguageSelect == 1)

                return ("أ مؤقت");

            else
                return ("Pause");


        }
        public static string stopv()
        {
            if (LanguageSelect == 1)

                return ("ايقاف");

            else
                return ("Stop");


        }
        public static string avalible()
        {
            if (LanguageSelect == 1)

                return ("من الهاتف");

            else
                return ("From phone");


        }
        public static string disavalible()
        {
            if (LanguageSelect == 1)

                return ("بث مباشر");

            else
                return ("online");


        }
        public static string additem()
        {
            if (LanguageSelect == 1)

                return ("تنزيل ايات");

            else
                return ("downloads");


        }
        public static string cancelitem()
        {
            if (LanguageSelect == 1)

                return ("الغاء ");

            else
                return ("Cancel");


        }
        public static void AutherList()
        {
             //120 read of quran
            AutherListInfo.Clear();
            if (LanguageSelect == 1)
            {
                AutherListInfo.Add(new AuthorClass() { ServerName = "shatri", RealName = "ابو بكر الشاطري" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ahmad_huth", RealName = "أحمد الحذيفي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hawashi", RealName = " أحمد الحواشي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "trabulsi", RealName = " أحمد الطرابلسي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ajm", RealName = "أحمد بن علي العجمي " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "trablsi", RealName = " أحمد خضر الطرابلسي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "saud", RealName = "أحمد سعود " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "saber", RealName = " أحمد صابر" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "Aamer", RealName = "أحمد عامر " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ahmad_nu", RealName = " أحمد نعينع" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "akil", RealName = " أخيل عبدالحي روا " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "akrm", RealName = " أكرم العلاقمي" });
                ////put in store
                AutherListInfo.Add(new AuthorClass() { ServerName = "akdr", RealName = " إبراهيم الأخضر" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "IbrahemSadan", RealName = " إبراهيم السعدان" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "abkr", RealName = " إدريس أبكر" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jbreen", RealName = " ابراهيم الجبرين" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jormy", RealName = " ابراهيم الجرمي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ibrahim_dosri_warsh", RealName = " ابراهيم الدوسري" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "3siri", RealName = "ابراهيم العسيري " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "zamri", RealName = " استاذ زامري " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "3zazi", RealName = "الحسيني العزازي " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "dokali", RealName = " الدوكالي محمد العالم" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "alzain", RealName = " الزين محمد أحمد" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "omran", RealName = "العشري عمران " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "koshi", RealName = " العيون الكوشي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "fateh", RealName = " الفاتح محمد الزبير" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qari", RealName = "القارئ ياسين " });

                ///new qura
                AutherListInfo.Add(new AuthorClass() { ServerName = "twfeeq", RealName = " توفيق الصايغ" }); //**
                AutherListInfo.Add(new AuthorClass() { ServerName = "jamal", RealName = " جمال شاكر عبدالله" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jaman", RealName = " جمعان العصيمي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hatem", RealName = " حاتم فريد الواع" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qht", RealName = " خالد القحطاني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mohna", RealName = " خالد المهنا" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "kafi", RealName = " خالد عبدالكافي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "tnjy", RealName = "خليفة الطنيجي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hamza", RealName = " داود حمزة" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ifrad", RealName = " رشيد إفراد" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "zaki", RealName = " زكي داغستاني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sami_dosr", RealName = " سامي الدوسري" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "s_gmd", RealName = " سعد الغامدي" }); //**
                AutherListInfo.Add(new AuthorClass() { ServerName = "shur", RealName = "سعود الشريم" });  //**
                AutherListInfo.Add(new AuthorClass() { ServerName = "shl", RealName = " سهل ياسين" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sayed", RealName = " سيد رمضان" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "taher", RealName = "شيرزاد عبدالرحمن طاهر" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hkm", RealName = " صابر عبدالحكم" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sahood", RealName = " صالح الصاهود" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "s_bud", RealName = " صلاح البدير" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "salah_hashim_m", RealName = " صلاح الهاشم" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bu_khtr", RealName = "صلاح بو خاطر" });//**
                AutherListInfo.Add(new AuthorClass() { ServerName = "tareq", RealName = "طارق عبدالغني دعوب" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "a_klb", RealName = " عادل الكلباني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ryan", RealName = " عادل ريان" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "thubti", RealName = " عبدالبارئ الثبيتي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bari", RealName = " عبدالبارئ محمد" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bari_molm", RealName = " عبدالبارئ محمد م" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "basit", RealName = " عبدالباسط عبدالصمد ح" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "basit_warsh", RealName = " عبدالباسط عبدالصمد و" });//**
                AutherListInfo.Add(new AuthorClass() { ServerName = "basit_mjwd", RealName = " عبدالباسط عبدالصمد  م" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sds", RealName = " عبدالرحمن السديس" });//**
                AutherListInfo.Add(new AuthorClass() { ServerName = "soufi_klf", RealName = " عبدالرشيد صوفي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "soufi", RealName = "عبدالرشيد صوفي س" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "a_ahmed", RealName = " عبدالعزيز الأحمد" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "brmi", RealName = " عبدالله البريمي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "Abdullahk", RealName = " عبدالله الكندري" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mtrod", RealName = " عبدالله المطرود" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bsfr", RealName = " عبدالله بصفر" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "kyat", RealName = " عبدالله خياط" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jhn", RealName = " عبدالله عواد الجهني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mohsin_harthi", RealName = " عبدالمحسن الحارثي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "obk", RealName = " عبدالمحسن العبيكان" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qasm", RealName = " عبدالمحسن القاسم" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "kanakeri", RealName = " عبدالهادي أحمد كناكري" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "wdod", RealName = " عبدالودود حنيف" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "abo_hashim", RealName = " علي أبو هاشم" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "huthifi_qalon", RealName = " علي الحذيفي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hthfi", RealName = " علي بن عبدالرحمن الحذيفي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "a_jbr", RealName = " علي جابر" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hajjaj", RealName = " علي حجاج السويسي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hafz", RealName = " عماد زهير حافظ" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "frs_a", RealName = " فارس عباد" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "lafi", RealName = " لافي العوني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "zaml", RealName = " ماجد الزامل" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shaibat", RealName = "مالك شيبة الحمد" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "maher_m", RealName = " ماهر المعيقلي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "maher", RealName = " ماهر المعيقلي ح" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shaksh", RealName = " ماهر شخاشير" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ayyub", RealName = " محمد أيوب" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "braak", RealName = " محمد البراك" }); //**
                AutherListInfo.Add(new AuthorClass() { ServerName = "tblawi", RealName = " محمد الطبلاوي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mhsny", RealName = " محمد المحيسني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "monshed", RealName = " محمد المنشد" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jbrl", RealName = " محمد جبريل" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "rashad", RealName = "محمد رشاد الشريف" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shah", RealName = " محمد صالح" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "minsh", RealName = " محمد صديق المنشاوي" });//**
                AutherListInfo.Add(new AuthorClass() { ServerName = "minsh_mjwd", RealName = "محمد صديق المنشاوي م" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "abdullah_dori", RealName = " محمد عبدالحكيم" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "khan", RealName = " محمد عثمان خان" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mrifai", RealName = " محمود الرفاعي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sheimy", RealName = " محمود الشيمي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "husr", RealName = " محمود خليل الحصري" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bna_mjwd", RealName = " محمود علي البنا" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "afs", RealName = " مشاري العفاسي" }); //**
                AutherListInfo.Add(new AuthorClass() { ServerName = "mustafa", RealName = " مصطفى إسماعيل" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "lahoni", RealName = " مصطفى اللاهوني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ra3ad", RealName = " مصطفى رعد العزاوي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "harthi", RealName = " معيض الحارثي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "muftah_thakwan", RealName = " مفتاح السلطني" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bilal", RealName = " موسى بلال" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qtm", RealName = " ناصر القطامي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "nabil", RealName = "  نبيل الرفاعي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "namh", RealName = " نعمة الحسان" });//^^
                AutherListInfo.Add(new AuthorClass() { ServerName = "hani", RealName = " هاني الرفاعي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "waleed", RealName = " وليد النائحي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "yasser", RealName = " ياسر الدوسري" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qurashi", RealName = " ياسر القرشي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mzroyee", RealName = "ياسر المزروعي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "yahya", RealName = " يحيى حوا" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "yousef", RealName = " يوسف الشويعي" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "noah", RealName = "يوسف بن نوح أحمد" });
               

            }





            else
            {
                AutherListInfo.Add(new AuthorClass() { ServerName = "shatri", RealName = "Abo Bakr AL-shtri" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ahmad_huth", RealName = "Ahmed Al-hadefy" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hawashi", RealName = " Ahmed Al-hoshy" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "trabulsi", RealName = " Ahmed Al-triblsy" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ajm", RealName = "Ahmed Al-ajmey " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "trablsi", RealName = " Ahmed Kudar Triblsy" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "saud", RealName = "Ahmed Suaad" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "saber", RealName = "Ahmed Sabar" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "Aamer", RealName = "Ahmed Amar" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ahmad_nu", RealName = "Ahmed Nineei" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "akil", RealName = "Kalel Abd-alhie" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "akrm", RealName = " Akram AL-alkime" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "akdr", RealName = " Abrihim Kudar" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "IbrahemSadan", RealName = " Abrihim sadan" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "abkr", RealName = " Adress bakir" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jbreen", RealName = " Abrihim jabrin" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jormy", RealName = "Abrihim jazme" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ibrahim_dosri_warsh", RealName = "  Abrihim dosey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "3siri", RealName = "Abrihim aseriy" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "zamri", RealName = "mister Ramze" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "3zazi", RealName = "Al-husaney Al-azaze" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "dokali", RealName = " Al-dokaley mohammed al-alm" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "alzain", RealName = " Alzin mohammed ahmed" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "omran", RealName = "Al-ashire auomran" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "koshi", RealName = " Al eyon alkoshe" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "fateh", RealName = " Al-fatih mohamed alzober" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qari", RealName = "Yasen al-kare " });
                /// update 
                ///new qura
                AutherListInfo.Add(new AuthorClass() { ServerName = "twfeeq", RealName = "Tofek alsaek" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jamal", RealName = "jamal shakr abd" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jaman", RealName = " joman al asime" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hatem", RealName = "hatem fared alwaey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qht", RealName = "khiled alkahtine" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mohna", RealName = " khilid almihin" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "kafi", RealName = " khilid almihin" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "tnjy", RealName = "kalefa altabnjey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hamza", RealName = "dawood hamza" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ifrad", RealName = " rashed afrad" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "zaki", RealName = "zake dakistine" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sami_dosr", RealName = "same aldosirey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "s_gmd", RealName = "saad alkamade" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shur", RealName = "sauuad alshirem" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shl", RealName = " sahil yasin" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sayed", RealName = " sayed ramadan" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "taher", RealName = "sherzad abd rahman" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hkm", RealName = " sabar abd alhakam" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sahood", RealName = " saleh alsahood" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "s_bud", RealName = "salah al badeer" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "salah_hashim_m", RealName = "salah alhashim" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bu_khtr", RealName = "salah abo katar" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "tareq", RealName = "tarek abd alkane" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "a_klb", RealName = " adel alklabine" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ryan", RealName = " adel rayan" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "thubti", RealName = "abd al barey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bari", RealName = "abd albarey mohammed" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bari_molm", RealName = " abd albarey mohammed M" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "basit", RealName = "abd albasit abd samad H" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "basit_warsh", RealName = " abd albasit abd samad w" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "basit_mjwd", RealName = " abd albasit abd samad M" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sds", RealName = " abd alrihman alsides" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "soufi_klf", RealName = " abd rashed sofe" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "soufi", RealName = "abd rashed sofe S" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "a_ahmed", RealName = "abd alaziz samad  " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "brmi", RealName = " abd alah barimey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "Abdullahk", RealName = " abd alah kindry" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mtrod", RealName = " abd alah matrood" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bsfr", RealName = " abd alah basfar" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "kyat", RealName = " abd alah kayat" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jhn", RealName = "abd alah awad" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mohsin_harthi", RealName = " abd ahmmahsin alharithey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "obk", RealName = " bd ahmmahsin alabekan" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qasm", RealName = " bd ahmmahsin alkasim" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "kanakeri", RealName = " abd alhidey ahmed " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "wdod", RealName = " abd awadood" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "abo_hashim", RealName = " ali abo hasim" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "huthifi_qalon", RealName = " ali alhithefy" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hthfi", RealName = " ali bin abd alrahman" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "a_jbr", RealName = " ali jabar" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hajjaj", RealName = " ali hajaj " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hafz", RealName = " amad zoheer" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "frs_a", RealName = " faaris abad" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "lafi", RealName = " lafey alawwney" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "zaml", RealName = " majad alzamel" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shaibat", RealName = "malak shiba" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "maher_m", RealName = " maheer al maeekly" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "maher", RealName = " maheer al maeekly H" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shaksh", RealName = " maheer shkasher" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ayyub", RealName = " mohammed ayoob" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "braak", RealName = " mohammed barak" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "tblawi", RealName = " mohammed altablaye" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mhsny", RealName = " mohammed almahsaney" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "monshed", RealName = "mohammed al minshid" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "jbrl", RealName = " mohamed jabril" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "rashad", RealName = " mohamed rashid " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "shah", RealName = " mohamed salih" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "minsh", RealName = " mohammed sadeek alminshawe" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "minsh_mjwd", RealName = "mohammed sadeek alminshawe M" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "abdullah_dori", RealName = " Mohamed abd alhakeem" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "khan", RealName = " mohammed athman kan" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mrifai", RealName = " mahmood alrifaey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "sheimy", RealName = " mahmmod alshimey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "husr", RealName = " mahmood kaley" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bna_mjwd", RealName = " mahmood ali" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "afs", RealName = " masharey alafasy" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mustafa", RealName = " mostaa asmael" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "lahoni", RealName = " mostafa allahoney" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "ra3ad", RealName = " mostafa raeed" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "harthi", RealName = " maeeth alharithey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "muftah_thakwan", RealName = " mafatf alsoltaney" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "bilal", RealName = "mosa balal" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qtm", RealName = "nasar alkamatey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "nabil", RealName = "nabeel alrafaeey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "namh", RealName = "naama alhasan" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "hani", RealName = "haney alrafaey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "waleed", RealName = " waleed alhaneha" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "yasser", RealName = " yasar dosary" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "qurashi", RealName = " yasar korashey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "mzroyee", RealName = "yasar mazroey" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "yahya", RealName = " yahya hawa" });
                AutherListInfo.Add(new AuthorClass() { ServerName = "yousef", RealName = " yoousif alshwaeey " });
                AutherListInfo.Add(new AuthorClass() { ServerName = "noah", RealName = "yousfi bin nooh" });
          
            }



        }

        public static void GuranAya(string RealServerFolder)
        {
              if (LanguageSelect == 1)
            {

            ListAya.Add(new AuthorClass() { ServerName = "001", RealName = " الفاتحة" });
            ListAya.Add(new AuthorClass() { ServerName = "002", RealName = "البقرة" });
            ListAya.Add(new AuthorClass() { ServerName = "003", RealName = "ال عمران " });
            ListAya.Add(new AuthorClass() { ServerName = "004", RealName = "النساء" });
            ListAya.Add(new AuthorClass() { ServerName = "005", RealName = " المائدة" });
            ListAya.Add(new AuthorClass() { ServerName = "006", RealName = " الانعام" });
            ListAya.Add(new AuthorClass() { ServerName = "007", RealName = " الأعراف" });
            ListAya.Add(new AuthorClass() { ServerName = "008", RealName = " الأنفال" });
            ListAya.Add(new AuthorClass() { ServerName = "009", RealName = " التوبة " });
            ListAya.Add(new AuthorClass() { ServerName = "010", RealName = " يونس" });
            ListAya.Add(new AuthorClass() { ServerName = "011", RealName = " هود" });
            ListAya.Add(new AuthorClass() { ServerName = "012", RealName = " يوسف" });
            ListAya.Add(new AuthorClass() { ServerName = "013", RealName = " الرعد" });
            ListAya.Add(new AuthorClass() { ServerName = "014", RealName = " إبراهيم" });
            ListAya.Add(new AuthorClass() { ServerName = "015", RealName = " الحجر" });
            ListAya.Add(new AuthorClass() { ServerName = "016", RealName = " النحل" });
            ListAya.Add(new AuthorClass() { ServerName = "017", RealName = " الإسراء" });
            ListAya.Add(new AuthorClass() { ServerName = "018", RealName = " الكهف" });
            ListAya.Add(new AuthorClass() { ServerName = "019", RealName = " مريم" });
            ListAya.Add(new AuthorClass() { ServerName = "020", RealName = " طه" });
            ListAya.Add(new AuthorClass() { ServerName = "021", RealName = " الأنبياء" });
            ListAya.Add(new AuthorClass() { ServerName = "022", RealName = " الحج" });
            ListAya.Add(new AuthorClass() { ServerName = "023", RealName = " المؤمنون" });
            ListAya.Add(new AuthorClass() { ServerName = "024", RealName = " النّور" });
            ListAya.Add(new AuthorClass() { ServerName = "025", RealName = "  الفرقان " });
            ListAya.Add(new AuthorClass() { ServerName = "026", RealName = "  الشعراء " });
            ListAya.Add(new AuthorClass() { ServerName = "027", RealName = " النّمل" });
            ListAya.Add(new AuthorClass() { ServerName = "028", RealName = " القصص" });
            ListAya.Add(new AuthorClass() { ServerName = "029", RealName = " العنكبوت" });
            ListAya.Add(new AuthorClass() { ServerName = "030", RealName = " الرّوم" });
            ListAya.Add(new AuthorClass() { ServerName = "031", RealName = " لقمان" });
            ListAya.Add(new AuthorClass() { ServerName = "032", RealName = " السجدة" });
            ListAya.Add(new AuthorClass() { ServerName = "033", RealName = " الأحزاب" });
            ListAya.Add(new AuthorClass() { ServerName = "034", RealName = " سبأ" });
            ListAya.Add(new AuthorClass() { ServerName = "035", RealName = " فاطر" });
            ListAya.Add(new AuthorClass() { ServerName = "036", RealName = " يس" });
            ListAya.Add(new AuthorClass() { ServerName = "037", RealName = " الصافات" });
            ListAya.Add(new AuthorClass() { ServerName = "038", RealName = " ص" });
            ListAya.Add(new AuthorClass() { ServerName = "039", RealName = " الزمر" });
            ListAya.Add(new AuthorClass() { ServerName = "040", RealName = " غافر" });
            ListAya.Add(new AuthorClass() { ServerName = "041", RealName = " فصّلت" });
            ListAya.Add(new AuthorClass() { ServerName = "042", RealName = " الشورى" });
            ListAya.Add(new AuthorClass() { ServerName = "043", RealName = " الزخرف" });
            ListAya.Add(new AuthorClass() { ServerName = "044", RealName = " الدّخان" });
            ListAya.Add(new AuthorClass() { ServerName = "045", RealName = " الجاثية" });
            ListAya.Add(new AuthorClass() { ServerName = "046", RealName = " الأحقاف" });
            ListAya.Add(new AuthorClass() { ServerName = "047", RealName = " محمد" });
            ListAya.Add(new AuthorClass() { ServerName = "048", RealName = " الفتح" });
            ListAya.Add(new AuthorClass() { ServerName = "049", RealName = " الحجرات" });
            ListAya.Add(new AuthorClass() { ServerName = "050", RealName = " ق" });
            ListAya.Add(new AuthorClass() { ServerName = "051", RealName = " الذاريات" });
            ListAya.Add(new AuthorClass() { ServerName = "052", RealName = " الطور" });
            ListAya.Add(new AuthorClass() { ServerName = "053", RealName = " النجم" });
            ListAya.Add(new AuthorClass() { ServerName = "054", RealName = " القمر" });
            ListAya.Add(new AuthorClass() { ServerName = "055", RealName = " الرحمن" });
            ListAya.Add(new AuthorClass() { ServerName = "056", RealName = " الواقعة" });
            ListAya.Add(new AuthorClass() { ServerName = "057", RealName = " الحديد" });
            ListAya.Add(new AuthorClass() { ServerName = "058", RealName = " المجادلة" });
            ListAya.Add(new AuthorClass() { ServerName = "059", RealName = " الحشر" });
            ListAya.Add(new AuthorClass() { ServerName = "060", RealName = " الممتحنة" });
            ListAya.Add(new AuthorClass() { ServerName = "061", RealName = " الصف" });
            ListAya.Add(new AuthorClass() { ServerName = "062", RealName = " الجمعة" });
            ListAya.Add(new AuthorClass() { ServerName = "063", RealName = " المنافقون" });
            ListAya.Add(new AuthorClass() { ServerName = "064", RealName = " التغابن" });
            ListAya.Add(new AuthorClass() { ServerName = "065", RealName = " الطلاق" });
            ListAya.Add(new AuthorClass() { ServerName = "066", RealName = " التحريم" });
            ListAya.Add(new AuthorClass() { ServerName = "067", RealName = " الملك" });
            ListAya.Add(new AuthorClass() { ServerName = "068", RealName = " القلم" });
            ListAya.Add(new AuthorClass() { ServerName = "069", RealName = " الحاقة" });
            ListAya.Add(new AuthorClass() { ServerName = "070", RealName = " المعارج" });
            ListAya.Add(new AuthorClass() { ServerName = "071", RealName = " نوح" });
            ListAya.Add(new AuthorClass() { ServerName = "072", RealName = " الجن" });
            ListAya.Add(new AuthorClass() { ServerName = "073", RealName = " المزّمّل" });
            ListAya.Add(new AuthorClass() { ServerName = "074", RealName = " المدّثر" });
            ListAya.Add(new AuthorClass() { ServerName = "075", RealName = " القيامة" });
            ListAya.Add(new AuthorClass() { ServerName = "076", RealName = " الإنسان" });
            ListAya.Add(new AuthorClass() { ServerName = "077", RealName = " المرسلات" });
            ListAya.Add(new AuthorClass() { ServerName = "078", RealName = " النبأ" });
            ListAya.Add(new AuthorClass() { ServerName = "079", RealName = " النازعات" });
            ListAya.Add(new AuthorClass() { ServerName = "080", RealName = " عبس" });
            ListAya.Add(new AuthorClass() { ServerName = "081", RealName = " التكوير" });
            ListAya.Add(new AuthorClass() { ServerName = "082", RealName = " الإنفطار" });
            ListAya.Add(new AuthorClass() { ServerName = "083", RealName = " المطفّفين" });
            ListAya.Add(new AuthorClass() { ServerName = "084", RealName = " الإنشقاق" });
            ListAya.Add(new AuthorClass() { ServerName = "085", RealName = " البروج" });
            ListAya.Add(new AuthorClass() { ServerName = "086", RealName = " الطارق" });
            ListAya.Add(new AuthorClass() { ServerName = "087", RealName = " الأعلى" });
            ListAya.Add(new AuthorClass() { ServerName = "088", RealName = " الغاشية" });
            ListAya.Add(new AuthorClass() { ServerName = "089", RealName = " الفجر" });
            ListAya.Add(new AuthorClass() { ServerName = "090", RealName = " البلد" });
            ListAya.Add(new AuthorClass() { ServerName = "091", RealName = " الشمس" });
            ListAya.Add(new AuthorClass() { ServerName = "092", RealName = " الليل" });
            ListAya.Add(new AuthorClass() { ServerName = "093", RealName = " الضحى" });
            ListAya.Add(new AuthorClass() { ServerName = "094", RealName = " الشرح" });
            ListAya.Add(new AuthorClass() { ServerName = "095", RealName = " التين" });
            ListAya.Add(new AuthorClass() { ServerName = "096", RealName = " العلق" });
            ListAya.Add(new AuthorClass() { ServerName = "097", RealName = " القدر" });
            ListAya.Add(new AuthorClass() { ServerName = "098", RealName = " البينة" });
            ListAya.Add(new AuthorClass() { ServerName = "099", RealName = " الزلزلة" });
            ListAya.Add(new AuthorClass() { ServerName = "100", RealName = " العاديات" });
            ListAya.Add(new AuthorClass() { ServerName = "101", RealName = " القارعة" });
            ListAya.Add(new AuthorClass() { ServerName = "102", RealName = " التكاثر" });
            ListAya.Add(new AuthorClass() { ServerName = "103", RealName = " العصر" });
            ListAya.Add(new AuthorClass() { ServerName = "104", RealName = " الهمزة" });
            ListAya.Add(new AuthorClass() { ServerName = "105", RealName = " الفيل" });
            ListAya.Add(new AuthorClass() { ServerName = "106", RealName = " قريش" });
            ListAya.Add(new AuthorClass() { ServerName = "107", RealName = " الماعون" });
            ListAya.Add(new AuthorClass() { ServerName = "108", RealName = " الكوثر" });
            ListAya.Add(new AuthorClass() { ServerName = "109", RealName = " الكافرون" });
            ListAya.Add(new AuthorClass() { ServerName = "110", RealName = " النصر" });
            ListAya.Add(new AuthorClass() { ServerName = "111", RealName = " المسد" });
            ListAya.Add(new AuthorClass() { ServerName = "112", RealName = " الإخلاص" });
            ListAya.Add(new AuthorClass() { ServerName = "113", RealName = " الفلق" });
            ListAya.Add(new AuthorClass() { ServerName = "114", RealName = " النّاس" });
            }
              else
              {
                  ListAya.Add(new AuthorClass() { ServerName = "001",RealName = " Al Fatha"});
                  ListAya.Add(new AuthorClass() { ServerName = "002",RealName = "Al  bakara"});
                  ListAya.Add(new AuthorClass() { ServerName = "003",RealName = "Al E imran"});
                  ListAya.Add(new AuthorClass() { ServerName = "004",RealName = "Al nisa"});
                  ListAya.Add(new AuthorClass() { ServerName = "005",RealName = " Al maeda"});
                  ListAya.Add(new AuthorClass() { ServerName = "006",RealName = " AL Anam"});
                  ListAya.Add(new AuthorClass() { ServerName = "007",RealName = " Al Aaraf"});
                  ListAya.Add(new AuthorClass() { ServerName = "008",RealName = " Al anfal"});
                  ListAya.Add(new AuthorClass() { ServerName = "009",RealName = " Al toba "});
                  ListAya.Add(new AuthorClass() { ServerName = "010", RealName =" Younis"});
                  ListAya.Add(new AuthorClass() { ServerName = "011",RealName = " Hood"});
                  ListAya.Add(new AuthorClass() { ServerName = "012",RealName = " Yousef"});
                  ListAya.Add(new AuthorClass() { ServerName = "013",RealName = " Ra'ad"});
                  ListAya.Add(new AuthorClass() { ServerName = "014",RealName = " Abrahim"});
                  ListAya.Add(new AuthorClass() { ServerName = "015",RealName = " Al hajar"});
                  ListAya.Add(new AuthorClass() { ServerName = "016", RealName =" Al nahal"});
                  ListAya.Add(new AuthorClass() { ServerName = "017",RealName = " Al esra"});
                  ListAya.Add(new AuthorClass() { ServerName = "018",RealName = " Al kahaf"});
                  ListAya.Add(new AuthorClass() { ServerName = "019",RealName = " Mareim"});
                  ListAya.Add(new AuthorClass() { ServerName = "020",RealName = " Ta-ha"});
                  ListAya.Add(new AuthorClass() { ServerName = "021",RealName = " Al anbea"});
                  ListAya.Add(new AuthorClass() { ServerName = "022",RealName = " AL haj"});
                  ListAya.Add(new AuthorClass() { ServerName = "023",RealName = " Al mo-manon"});
                  ListAya.Add(new AuthorClass() { ServerName = "024",RealName = " Al noor"});
                  ListAya.Add(new AuthorClass() { ServerName = "025",RealName = "  Al forkan "});
                  ListAya.Add(new AuthorClass() { ServerName = "026",RealName = "  Al shoara "});
                  ListAya.Add(new AuthorClass() { ServerName = "027",RealName = " Al  namal"});
                  ListAya.Add(new AuthorClass() { ServerName = "028",RealName = " AL Ka-sas"});
                  ListAya.Add(new AuthorClass() { ServerName = "029",RealName = " AL an-kabot"});
                  ListAya.Add(new AuthorClass() { ServerName = "030",RealName = " AL rom'"});
                  ListAya.Add(new AuthorClass() { ServerName = "031",RealName = " Lokman"});
                  ListAya.Add(new AuthorClass() { ServerName = "032",RealName = " sajda"});
                  ListAya.Add(new AuthorClass() { ServerName = "033",RealName = " ah-zab"});
                  ListAya.Add(new AuthorClass() { ServerName = "034",RealName = " saba"});
                  ListAya.Add(new AuthorClass() { ServerName = "035",RealName = " fatar"});
                  ListAya.Add(new AuthorClass() { ServerName = "036",RealName = " ya-seen"});
                  ListAya.Add(new AuthorClass() { ServerName = "037",RealName = " al safat"});
                  ListAya.Add(new AuthorClass() { ServerName = "038",RealName = " S-at'"});
                  ListAya.Add(new AuthorClass() { ServerName = "039",RealName = " al zomar"});
                  ListAya.Add(new AuthorClass() { ServerName = "040",RealName = " ca-far"});
                  ListAya.Add(new AuthorClass() { ServerName = "041",RealName = " fo-salat"});
                  ListAya.Add(new AuthorClass() { ServerName = "042",RealName = " al shora"});
                  ListAya.Add(new AuthorClass() { ServerName = "043",RealName = " al zokraf"});
                  ListAya.Add(new AuthorClass() { ServerName = "044",RealName = " al dokan"});
                  ListAya.Add(new AuthorClass() { ServerName = "045",RealName = " al ja-thea"});
                  ListAya.Add(new AuthorClass() { ServerName = "046",RealName = " al ahkaf"});
                  ListAya.Add(new AuthorClass() { ServerName = "047", RealName =" mohammed"});
                  ListAya.Add(new AuthorClass() { ServerName = "048",RealName = " al fatah"});
                  ListAya.Add(new AuthorClass() { ServerName = "049",RealName = " ah ha-jarat"});
                  ListAya.Add(new AuthorClass() { ServerName = "050",RealName = " k-af"});
                  ListAya.Add(new AuthorClass() { ServerName = "051",RealName = " al tharait"});
                  ListAya.Add(new AuthorClass() { ServerName = "052",RealName = " al toor"});
                  ListAya.Add(new AuthorClass() { ServerName = "053", RealName =" al najam"});
                  ListAya.Add(new AuthorClass() { ServerName = "054", RealName =" al kamar"});
                  ListAya.Add(new AuthorClass() { ServerName = "055",RealName = " al rahman"});
                  ListAya.Add(new AuthorClass() { ServerName = "056",RealName = " al wakea"});
                  ListAya.Add(new AuthorClass() { ServerName = "057",RealName = " al haded"});
                  ListAya.Add(new AuthorClass() { ServerName = "058",RealName = " al mojadala"});
                  ListAya.Add(new AuthorClass() { ServerName = "059",RealName = " al hashar"});
                  ListAya.Add(new AuthorClass() { ServerName = "060",RealName = " al mom-tahana"});
                  ListAya.Add(new AuthorClass() { ServerName = "061",RealName = " al saf"});
                  ListAya.Add(new AuthorClass() { ServerName = "062",RealName = " al joma'"});
                  ListAya.Add(new AuthorClass() { ServerName = "063",RealName = " al monafakon"});
                  ListAya.Add(new AuthorClass() { ServerName = "064",RealName = " al takabon"});
                  ListAya.Add(new AuthorClass() { ServerName = "065",RealName = " al talak"});
                  ListAya.Add(new AuthorClass() { ServerName = "066",RealName = " al tahram"});
                  ListAya.Add(new AuthorClass() { ServerName = "067",RealName = " al molk"});
                  ListAya.Add(new AuthorClass() { ServerName = "068",RealName = " al kalam"});
                  ListAya.Add(new AuthorClass() { ServerName = "069",RealName = " al haka"});
                  ListAya.Add(new AuthorClass() { ServerName = "070",RealName = " al ma'-arj"});
                  ListAya.Add(new AuthorClass() { ServerName = "071",RealName = " nooh"});
                  ListAya.Add(new AuthorClass() { ServerName = "072",RealName = " al jn"});
                  ListAya.Add(new AuthorClass() { ServerName = "073",RealName = " a lmozamal"});
                  ListAya.Add(new AuthorClass() { ServerName = "074",RealName = " al modathar"});
                  ListAya.Add(new AuthorClass() { ServerName = "075", RealName =" al kyama"});
                  ListAya.Add(new AuthorClass() { ServerName = "076",RealName = " al ansan"});
                  ListAya.Add(new AuthorClass() { ServerName = "077",RealName = " al morasalat"});
                  ListAya.Add(new AuthorClass() { ServerName = "078",RealName = "  naba"});
                  ListAya.Add(new AuthorClass() { ServerName = "079",RealName = " al nazat"});
                  ListAya.Add(new AuthorClass() { ServerName = "080",RealName = " ab-as"});
                  ListAya.Add(new AuthorClass() { ServerName = "081",RealName = " al tkawer"});
                  ListAya.Add(new AuthorClass() { ServerName = "082",RealName = " a lanfatar"});
                  ListAya.Add(new AuthorClass() { ServerName = "083",RealName = " al motafafen"});
                  ListAya.Add(new AuthorClass() { ServerName = "084",RealName = " al anshkak"});
                  ListAya.Add(new AuthorClass() { ServerName = "085",RealName = " al brooj"});
                  ListAya.Add(new AuthorClass() { ServerName = "086",RealName = " al tarek"});
                  ListAya.Add(new AuthorClass() { ServerName = "087",RealName = " al ala"});
                  ListAya.Add(new AuthorClass() { ServerName = "088",RealName = " al kashay"});
                  ListAya.Add(new AuthorClass() { ServerName = "089",RealName = " al fajar"});
                  ListAya.Add(new AuthorClass() { ServerName = "090",RealName = " a lbalad"});
                  ListAya.Add(new AuthorClass() { ServerName = "091",RealName = " al shmas"});
                  ListAya.Add(new AuthorClass() { ServerName = "092",RealName = " al layl"});
                  ListAya.Add(new AuthorClass() { ServerName = "093",RealName = " al doha"});
                  ListAya.Add(new AuthorClass() { ServerName = "094",RealName = " al sharh"});
                  ListAya.Add(new AuthorClass() { ServerName = "095",RealName = " al ten"});
                  ListAya.Add(new AuthorClass() { ServerName = "096",RealName = " al alak"});
                  ListAya.Add(new AuthorClass() { ServerName = "097",RealName = " al kadar"});
                  ListAya.Add(new AuthorClass() { ServerName = "098",RealName = " al bayana"});
                  ListAya.Add(new AuthorClass() { ServerName = "099",RealName = " al zalzala"});
                  ListAya.Add(new AuthorClass() { ServerName = "100",RealName = " al adiyat"});
                  ListAya.Add(new AuthorClass() { ServerName = "101", RealName =" al karea"});
                  ListAya.Add(new AuthorClass() { ServerName = "102", RealName =" al takathor"});
                  ListAya.Add(new AuthorClass() { ServerName = "103",RealName = " al asar"});
                  ListAya.Add(new AuthorClass() { ServerName = "104",RealName = " al hamza"});
                  ListAya.Add(new AuthorClass() { ServerName = "105", RealName =" al feel"});
                  ListAya.Add(new AuthorClass() { ServerName = "106",RealName = " korash"});
                  ListAya.Add(new AuthorClass() { ServerName = "107", RealName =" al ma-on"});
                  ListAya.Add(new AuthorClass() { ServerName = "108", RealName =" al kaothar"});
                  ListAya.Add(new AuthorClass() { ServerName = "109", RealName =" al kafiron"});
                  ListAya.Add(new AuthorClass() { ServerName = "110", RealName =" al nasr"});
                  ListAya.Add(new AuthorClass() { ServerName = "111",RealName = " al msad"});
                  ListAya.Add(new AuthorClass() { ServerName = "112",RealName = " al aklas"});
                  ListAya.Add(new AuthorClass() { ServerName = "113", RealName =" al falak"});
                  ListAya.Add(new AuthorClass() { ServerName = "114", RealName =" al nas"});
              }
            ListBeginEndAya ListRange = new ListBeginEndAya();
            ListRange = managment.autherRanageDetermine(RealServerFolder);
            ListAyaRanage.Clear();
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication();

            for (int i = ListRange.beginR; i < ListRange.endread; i++)
            { 
                // check the file state
               // string transferFileName = "http://server" + managment.serverNumber(RealServerFolder) + ".mp3quran.net/" + RealServerFolder + "/" + ListAya[i].RealName + ".mp3";
                

            string[] files = isoStore.GetFileNames(RealServerFolder+ListAya[i].ServerName +".mp3");
                
                    if (files.Length>0)
                         
                        ListAyaRanage.Add(new AuthorClass() { ServerName = ListAya[i].ServerName, RealName = ListAya[i].RealName, StateName = avalible(), ImgUrl = "ImageSetting/img_btn_play.png" });
                    else
                        ListAyaRanage.Add(new AuthorClass() { ServerName = ListAya[i].ServerName, RealName = ListAya[i].RealName, StateName = disavalible(), ImgUrl = "ImageSetting/img_btn_play.png" });
                    

               

            

            }
        }




 









    }
    
    
}
